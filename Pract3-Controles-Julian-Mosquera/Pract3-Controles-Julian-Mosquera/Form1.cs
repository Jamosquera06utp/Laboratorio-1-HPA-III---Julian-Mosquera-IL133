using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_Controles_Julian_Mosquera
{
    public partial class Pract8EstrcuturaIf3 : Form
    {
        public Pract8EstrcuturaIf3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gboxOperaciones_Enter(object sender, EventArgs e)
        {

        }

        //creare un metodo que se llame en cada radio button
        // Método para realizar la operación
        private void Calcular()
        {

            //incializacion de num1 y num2 ya que dio error sin iniciarlizarlo
            decimal num1 = 0;
            decimal num2 = 0;
            // Validar que los datos ingresados sean validso
            if (!decimal.TryParse(textBox1.Text, out num1) || !decimal.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Ingrese un valor numerico");
            }

            decimal resultado = 0;
            
            // calculos
            if (rbnSuma.Checked)
            {
                resultado = num1 + num2;
            }
            else if (rbnResta.Checked)
            {
                resultado = num1 - num2;
            }
            else if (rbnMultiplicacion.Checked)
            {
                resultado = num1 * num2;
            }
            else if (rbnDivision.Checked) //no se puede dividir entre 0
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    textBox3.Text = "Error";
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }
            }

            // Resultado
            textBox3.Text = resultado.ToString();
        }

       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //este al exportar entiendo que deberia dar error ya que no es el nombre de la variable pero 
        //a la hora de cambiarlo no detecta el cambio de nombre no se ha que se debe
        
        
            //private void rbnResta_CheckedChanged(object sender, EventArgs e)

        {
            if (rbnResta.Checked)
            {
                lblOperador.Text = "-";
            }
            if (rbnResta.Checked) Calcular();
        }

        private void rbnSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSuma.Checked)
            {
                lblOperador.Text = "+";
            }
            if (rbnSuma.Checked) Calcular();
        }

        private void rbnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMultiplicacion.Checked)
            {
                lblOperador.Text = "x";
            }
            if (rbnMultiplicacion.Checked) Calcular();
        }

        private void rbnDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnDivision.Checked)
            {
                lblOperador.Text = "/";
            }
            if (rbnDivision.Checked) Calcular();
        }
    }
}
