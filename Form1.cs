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

namespace controlDeColores
{
    public partial class Form1 : Form
    {
        private int colorRed;
        private int colorGreen;
        private int colorBlue;
        private int valueRGB;
        private int valueHEX;
        SerialPort serialPortX = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorRed = 0;
            colorGreen = 0;
            colorBlue = 0;

            tbRed.Value = colorRed;
            tbGreen.Value = colorGreen;
            tbBlue.Value = colorBlue;

            lblRed.Text = colorRed.ToString();
            lblGreen.Text = colorGreen.ToString();
            lblBlue.Text = colorBlue.ToString();

            pnlColor.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            txtRGB.Text = $"({colorRed.ToString()}, {colorGreen.ToString()} , {colorBlue.ToString()})";
            txtHexa.Text = $"#{colorRed.ToString("X2")}{colorGreen.ToString("X2")}{colorBlue.ToString("X2")}";

        }


        public void colorPanel()
        {
            lblRed.Text = tbRed.Value.ToString();
            lblGreen.Text = tbGreen.Value.ToString();
            lblBlue.Text = tbBlue.Value.ToString();

            pnlColor.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            txtRGB.Text = $"{tbRed.Value}, {tbGreen.Value} , {tbBlue.Value}";
            txtHexa.Text = $"#{tbRed.Value.ToString("X2")}{tbGreen.Value.ToString("X2")}{tbBlue.Value.ToString("X2")}";
        }


        private void tbRed_Scroll(object sender, EventArgs e)
        {
            colorPanel();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            colorPanel();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            colorPanel();
        }

        private void cbSerialPort_DropDown(object sender, EventArgs e)
        {

            cbSerialPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach(var port in ports)
            {
                cbSerialPort.Items.Add(port);
            }
        }


        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortX.PortName = cbSerialPort.Text;
                serialPortX.BaudRate = 9600;
                serialPortX.DataBits = 8;
                serialPortX.Parity = Parity.None;
                serialPortX.StopBits = StopBits.One;
                serialPortX.RtsEnable = true;

                serialPortX.Open();
                serialPortX.WriteLine(valueHEX.ToString());
                serialPortX.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error algo ha salido mal", ex.Message);
            }
        }

        private void btnMostrarControl_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            control.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
