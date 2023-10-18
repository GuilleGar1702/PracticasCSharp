using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CaracterChecker(char caracter)
        {
            char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return caracteres.Contains(caracter) || char.IsControl(caracter);

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(TxtBxNumero.Text);
            if (Numero % 2==0)
            {
                LblMensaje.Text = "El número es par";
            }
            else
            {
                LblMensaje.Text = "El número es impar";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
