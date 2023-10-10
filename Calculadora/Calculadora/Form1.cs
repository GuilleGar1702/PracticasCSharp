using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblRespuesta_Click(object sender, EventArgs e)
        {

        }

        public bool CaracterChecker(char caracter)
        {
            char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', 'e', 'E', '-' };

            return caracteres.Contains(caracter) || char.IsControl(caracter);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = x * y;
            LblResultado.Text = Convert.ToString(z);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = x + y;
            LblResultado.Text = Convert.ToString(z);
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = x - y;
            LblResultado.Text = Convert.ToString(z);
        }

        private void BtnCociente_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = x / y;
            LblResultado.Text = Convert.ToString(z);
        }

        private void BtnPotencia_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = Convert.ToDouble(x);
            if (y==0)
            {
                LblResultado.Text = "1";
            }
            else
            {
                for (double i = 1; i < y; i++)
                {
                    z = z * x;
                }
                LblResultado.Text = Convert.ToString(z);
            }
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TxtBxPrimerElemento.Text = "0";
            TxtBxSegundoElemento.Text = "0";
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBxPrimerElemento.Text);
            double y = Convert.ToDouble(TxtBxSegundoElemento.Text);
            double z = Math.Pow(x, 1.0/y);
            LblResultado.Text = Convert.ToString(z);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxPrimerElemento.Text = "0";
            TxtBxSegundoElemento.Text = "0";
            LblResultado.Text = "";
        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            TxtBxPrimerElemento.Text = LblResultado.Text;
            TxtBxSegundoElemento.Text = "0";
            LblResultado.Text = "";
        }


        private void TxtBxPrimerElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar =='.' && TxtBxPrimerElemento.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void TxtBxPrimerElemento_Click(object sender, EventArgs e) => TxtBxPrimerElemento.Text = "";

        private void TxtBxSegundoElemento_Click(object sender, EventArgs e) => TxtBxSegundoElemento.Text = "";
        
        

        private void TxtBxPrimerElemento_Leave(object sender, EventArgs e)
        {
            if (TxtBxPrimerElemento.Text == "")
            {
                TxtBxPrimerElemento.Text = "0";
            }
        }

        private void TxtBxSegundoElemento_Leave(object sender, EventArgs e)
        {
            if (TxtBxSegundoElemento.Text == "")
            {
                TxtBxSegundoElemento.Text = "0";
            }
        }

        private void TxtBxSegundoElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && TxtBxSegundoElemento.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void BtnExtend_Click(object sender, EventArgs e)
        {
            Form2 Extension = new Form2();
            Extension.Show();
        }
    }
    
}