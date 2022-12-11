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
    public partial class ControlColores : Form
    {
        private int colorRed;
        private int colorGreen;
        private int colorBlue;
        //private int valueRGB;
        //private int valueHEX;
        private string nameBtnColor = "";
        private Color backColorBtn;
        private List<Color> ListColors = new List<Color>();

        SerialPort serialPortX = new SerialPort();

        public ControlColores()
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

            pnlLed1.BackColor = backColorBtn;
            pnlLed2.BackColor = backColorBtn;
            pnlLed3.BackColor = backColorBtn;
            pnlLed4.BackColor = backColorBtn;
            pnlLed5.BackColor = backColorBtn;
            pnlLed6.BackColor = backColorBtn;

            //try
            //{
            //    serialPortX.PortName = cbSerialPort.Text;
            //    serialPortX.BaudRate = 9600;
            //    serialPortX.DataBits = 8;
            //    serialPortX.Parity = Parity.None;
            //    serialPortX.StopBits = StopBits.One;
            //    serialPortX.RtsEnable = true;

            //    serialPortX.Open();
            //    serialPortX.WriteLine(valueHEX.ToString());
            //    serialPortX.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error algo ha salido mal", ex.Message);
            //}
        }

        private void btnGuardarColor_Click(object sender, EventArgs e)
        {
            foreach(Button btnColor in grpControl.Controls)
            {
                if (btnColor.Name == nameBtnColor)
                {
                    btnColor.BackColor = pnlColor.BackColor;
                }
            }
        }

        private void btnCtrl1_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl1.Name;
            backColorBtn = btnCtrl1.BackColor;
        }

        private void btnCtrl2_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl2.Name;
            backColorBtn = btnCtrl2.BackColor;
        }

        private void btnCtrl3_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl3.Name;
            backColorBtn = btnCtrl3.BackColor;
        }

        private void btnCtrl4_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl4.Name;
            backColorBtn = btnCtrl4.BackColor;
        }

        private void btnCtrl5_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl5.Name;
            backColorBtn = btnCtrl5.BackColor;
        }

        private void btnCtrl6_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl6.Name;
            backColorBtn = btnCtrl6.BackColor;
        }

        private void btnCtrl7_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl7.Name;
            backColorBtn = btnCtrl7.BackColor;
        }

        private void btnCtrl8_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl8.Name;
            backColorBtn = btnCtrl8.BackColor;
        }

        private void btnCtrl9_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl9.Name;
            backColorBtn = btnCtrl9.BackColor;
        }

        private void btnCtrl10_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl10.Name;
            backColorBtn = btnCtrl10.BackColor;
        }

        private void btnCtrl11_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl11.Name;
            backColorBtn = btnCtrl11.BackColor;
        }

        private void btnCtrl12_Click(object sender, EventArgs e)
        {
            nameBtnColor = btnCtrl12.Name;
            backColorBtn = btnCtrl12.BackColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearSucesion_Click(object sender, EventArgs e)
        {
            foreach(var color in ListColors)
            {
                lbColores.Items.Add(color.ToString());
            }
        }

        private void btnAgregarColorSucesion_Click(object sender, EventArgs e)
        {
            ListColors.Add(backColorBtn);
        }
    }
}
