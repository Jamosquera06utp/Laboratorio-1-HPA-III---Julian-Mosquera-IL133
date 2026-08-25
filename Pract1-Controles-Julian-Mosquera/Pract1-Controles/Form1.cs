using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class PracticaDeControles : Form
    {
        public PracticaDeControles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDia.Text != "" && txtMes.Text != "" && txtAño.Text != "")
                lblFechaEs.Text = txtDia.Text + ", " + txtMes.Text + ", " + txtAño.Text;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa");
            MessageBoxIcon icon = MessageBoxIcon.Information; //no supe usarlo upsi
            MessageBox.Show("Cerrando... ");
            Close();

        }

        private void PDia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
