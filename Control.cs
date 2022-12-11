using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlDeColores
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 colores = new Form1();
            colores.Show();
            this.Hide();
        }
    }
}
