
namespace ProyectoArduino
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboVelocidad = new System.Windows.Forms.ComboBox();
            this.cboPuerto = new System.Windows.Forms.ComboBox();
            this.lblVelosidad = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.chartGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.cboVelocidad);
            this.groupBox1.Controls.Add(this.cboPuerto);
            this.groupBox1.Controls.Add(this.lblVelosidad);
            this.groupBox1.Controls.Add(this.lblPuerto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conf. del puerto COM";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRefrescar.Location = new System.Drawing.Point(64, 176);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(84, 26);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConectar.Location = new System.Drawing.Point(64, 128);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(84, 28);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboVelocidad
            // 
            this.cboVelocidad.FormattingEnabled = true;
            this.cboVelocidad.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115600"});
            this.cboVelocidad.Location = new System.Drawing.Point(106, 82);
            this.cboVelocidad.Name = "cboVelocidad";
            this.cboVelocidad.Size = new System.Drawing.Size(97, 24);
            this.cboVelocidad.TabIndex = 3;
            // 
            // cboPuerto
            // 
            this.cboPuerto.FormattingEnabled = true;
            this.cboPuerto.Location = new System.Drawing.Point(106, 38);
            this.cboPuerto.Name = "cboPuerto";
            this.cboPuerto.Size = new System.Drawing.Size(97, 24);
            this.cboPuerto.TabIndex = 2;
            // 
            // lblVelosidad
            // 
            this.lblVelosidad.AutoSize = true;
            this.lblVelosidad.Location = new System.Drawing.Point(6, 90);
            this.lblVelosidad.Name = "lblVelosidad";
            this.lblVelosidad.Size = new System.Drawing.Size(83, 16);
            this.lblVelosidad.TabIndex = 1;
            this.lblVelosidad.Text = "Velocidad:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(6, 41);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(94, 16);
            this.lblPuerto.TabIndex = 0;
            this.lblPuerto.Text = "Puerto COM:";
            // 
            // chartGrafica
            // 
            this.chartGrafica.BackColor = System.Drawing.Color.Lavender;
            this.chartGrafica.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrafica.Legends.Add(legend1);
            this.chartGrafica.Location = new System.Drawing.Point(14, 10);
            this.chartGrafica.Name = "chartGrafica";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.LightGreen;
            series1.Legend = "Legend1";
            series1.Name = "Nivel de Temperatura";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Nivel de gas y humo";
            this.chartGrafica.Series.Add(series1);
            this.chartGrafica.Series.Add(series2);
            this.chartGrafica.Size = new System.Drawing.Size(456, 237);
            this.chartGrafica.TabIndex = 0;
            this.chartGrafica.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHumedad);
            this.panel1.Controls.Add(this.lblTemperatura);
            this.panel1.Controls.Add(this.chartGrafica);
            this.panel1.Location = new System.Drawing.Point(261, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 262);
            this.panel1.TabIndex = 1;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.White;
            this.lblHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(372, 145);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(46, 37);
            this.lblHumedad.TabIndex = 3;
            this.lblHumedad.Text = "%";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.White;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(372, 96);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(41, 37);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(12, 278);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cboVelocidad;
        private System.Windows.Forms.ComboBox cboPuerto;
        private System.Windows.Forms.Label lblVelosidad;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblTemperatura;
        private System.IO.Ports.SerialPort PuertoSerial;
    }
}

