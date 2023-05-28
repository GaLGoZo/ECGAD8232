namespace ECGAD8232
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbPuertosConexion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudios = new System.Windows.Forms.ComboBox();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.gbMonitor = new System.Windows.Forms.GroupBox();
            this.chartPulsasiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrFrecuencia = new System.Windows.Forms.Timer(this.components);
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.gbPuertosConexion.SuspendLayout();
            this.gbMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPulsasiones)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPuertosConexion
            // 
            this.gbPuertosConexion.Controls.Add(this.label2);
            this.gbPuertosConexion.Controls.Add(this.label1);
            this.gbPuertosConexion.Controls.Add(this.cmbBaudios);
            this.gbPuertosConexion.Controls.Add(this.cmbPuertos);
            this.gbPuertosConexion.Controls.Add(this.btnDesconectar);
            this.gbPuertosConexion.Controls.Add(this.btnConectar);
            this.gbPuertosConexion.Location = new System.Drawing.Point(12, 12);
            this.gbPuertosConexion.Name = "gbPuertosConexion";
            this.gbPuertosConexion.Size = new System.Drawing.Size(1321, 162);
            this.gbPuertosConexion.TabIndex = 0;
            this.gbPuertosConexion.TabStop = false;
            this.gbPuertosConexion.Text = "PANEL DE PUERTOS SERIALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "BAUDIOS : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "PUERTOS : ";
            // 
            // cmbBaudios
            // 
            this.cmbBaudios.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudios.FormattingEnabled = true;
            this.cmbBaudios.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudios.Location = new System.Drawing.Point(150, 89);
            this.cmbBaudios.Name = "cmbBaudios";
            this.cmbBaudios.Size = new System.Drawing.Size(121, 42);
            this.cmbBaudios.TabIndex = 3;
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(150, 32);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(121, 42);
            this.cmbPuertos.TabIndex = 2;
            this.cmbPuertos.DropDown += new System.EventHandler(this.PuertosDropDown);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(1061, 95);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(240, 46);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(1061, 30);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(240, 46);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.chartPulsasiones);
            this.gbMonitor.Location = new System.Drawing.Point(12, 190);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Size = new System.Drawing.Size(1321, 594);
            this.gbMonitor.TabIndex = 1;
            this.gbMonitor.TabStop = false;
            this.gbMonitor.Text = "MONITOR DE PULSASIONES";
            // 
            // chartPulsasiones
            // 
            this.chartPulsasiones.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Silver;
            this.chartPulsasiones.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPulsasiones.Legends.Add(legend2);
            this.chartPulsasiones.Location = new System.Drawing.Point(6, 19);
            this.chartPulsasiones.Name = "chartPulsasiones";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Analog";
            series2.YValuesPerPoint = 4;
            this.chartPulsasiones.Series.Add(series2);
            this.chartPulsasiones.Size = new System.Drawing.Size(1309, 569);
            this.chartPulsasiones.TabIndex = 4;
            this.chartPulsasiones.Text = "chart1";
            // 
            // tmrFrecuencia
            // 
            this.tmrFrecuencia.Tick += new System.EventHandler(this.tmrFrecuencia_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 805);
            this.Controls.Add(this.gbMonitor);
            this.Controls.Add(this.gbPuertosConexion);
            this.Name = "MenuForm";
            this.Text = "ECGAD8232";
            this.Load += new System.EventHandler(this.FormLoad);
            this.gbPuertosConexion.ResumeLayout(false);
            this.gbPuertosConexion.PerformLayout();
            this.gbMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPulsasiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuertosConexion;
        private System.Windows.Forms.GroupBox gbMonitor;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaudios;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPulsasiones;
        private System.Windows.Forms.Timer tmrFrecuencia;
        private System.IO.Ports.SerialPort spArduino;
    }
}

