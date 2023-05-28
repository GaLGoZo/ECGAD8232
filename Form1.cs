using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGAD8232
{
    public partial class MenuForm : Form
    {
        delegate void serialCalback(string val);
        double x;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            tmrFrecuencia.Tick += tmrFrecuencia_Tick;
            chartPulsasiones.Series[0].IsVisibleInLegend = false;
        }


        private void PuertosDropDown(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            cmbPuertos.Items.Clear();
            cmbPuertos.Items.AddRange(portList);
        }

        //Metodo extra creado para mandar los datos obtenidos del arduino en la lectura analoga dirigidas al monitor serial de visual studio

        private void chartsetText(string val)
        {
            if (this.chartPulsasiones.InvokeRequired)
            {
                serialCalback scb = new serialCalback(chartsetText);
                this.BeginInvoke(scb, new object[] { val });
            }
            else
            {
                if (!String.Equals("!", val))
                {
                    chartPulsasiones.Series[0].Points.AddXY(x, val);
                }
            }
        }

        private void tmrFrecuencia_Tick(object sender, EventArgs e)
        {
            string incomString = spArduino.ReadLine();
            chartsetText(incomString);

            //if(String.Equals(incomString,"0"))
            //{
            //    serialPort.Write("0");
            //}

            if (chartPulsasiones.Series[0].Points.Count > 100) chartPulsasiones.Series[0].Points.RemoveAt(0);

            chartPulsasiones.ChartAreas[0].AxisX.Minimum = chartPulsasiones.Series[0].Points[0].XValue;
            chartPulsasiones.ChartAreas[0].AxisX.Maximum = x;

            x += 1;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!spArduino.IsOpen)
            {
                try
                {
                    spArduino.PortName = cmbPuertos.Text;
                    spArduino.BaudRate = Convert.ToInt32(cmbBaudios.Text);
                    spArduino.Open();

                    MessageBox.Show("Conexion a arduino completada");
                    btnDesconectar.Enabled = true;
                    btnConectar.Enabled = false;
                    chartPulsasiones.Series[0].Points.Clear();
                    tmrFrecuencia.Start();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (spArduino.IsOpen)
            {
                try
                {
                    tmrFrecuencia.Stop();
                    spArduino.Close();

                    MessageBox.Show("Conexion a arduino terminada");
                    btnDesconectar.Enabled = false;
                    btnConectar.Enabled = true;
                    chartPulsasiones.Series[0].Points.Clear();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
