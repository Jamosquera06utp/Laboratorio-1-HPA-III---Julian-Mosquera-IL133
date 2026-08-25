using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Descuentos
{
    public partial class PracticaDeVentas : Form
    {
        public PracticaDeVentas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Validar que se ingreso un valor 

            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor.");
                return;
            }            // Validar que se ingresó un numero valido
            if (decimal.TryParse(txtValor.Text, out decimal venta))
            {
                decimal porcentaje = 0m;

                if (venta >= 500)
                {
                    porcentaje = 0.30m;
                }
                else if (venta > 300 && venta <= 499)
                {
                    porcentaje = 0.20m;
                }
                else if (venta > 100 && venta <= 299)
                {
                    porcentaje = 0.10m;
                }
                else
                {
                    porcentaje = 0;
                }

                // calculos
                decimal descuentoMonto = venta * porcentaje;
                decimal ventaFinal = venta - descuentoMonto;

                txtDinDescuento.Text = descuentoMonto.ToString();
                txtPorDescuento.Text = (porcentaje * 100).ToString() + "%";
                txtPrecioF.Text = ventaFinal.ToString();

            }
            
            //Else para error de validacion en entrada
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numerico.");
            }
            }
        
        private void txtDinDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas eliminar este registro?",
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) {
                txtValor.Clear();
                txtDinDescuento.Clear();
                txtPorDescuento.Clear();
                txtPrecioF.Clear();
            }
    }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando el programa... ");
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
