using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProyectoArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;
            btnRefrescar.Enabled = false;
            cboVelocidad.Text = "9600";

            string[] PL = SerialPort.GetPortNames();
            cboPuerto.Items.AddRange(PL);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                PuertoSerial.PortName = cboPuerto.Text;
                PuertoSerial.BaudRate = Convert.ToInt32(cboVelocidad.Text);
                PuertoSerial.Open();

                btnConectar.Enabled = true;
                btnRefrescar.Enabled = true;
               
                cboVelocidad.Enabled = false;
                cboPuerto.Enabled = false;
                btnConectar.Text = "Desconectar";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (PuertoSerial.IsOpen)
            {
                try
                {
                    PuertoSerial.WriteLine("#Off");

                    PuertoSerial.Close();
                    btnConectar.Enabled = true;
                    btnRefrescar.Enabled = true;
                   
                    cboPuerto.Enabled = true;
                    cboVelocidad.Enabled = true;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
