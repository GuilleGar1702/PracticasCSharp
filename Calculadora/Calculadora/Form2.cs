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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool CaracterChecker(char caracter)
        {
            char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', 'e', 'E', '-' };

            return caracteres.Contains(caracter) || char.IsControl(caracter);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = ColorTranslator.FromHtml("#02A1BE");
            TxtBxX.Text = "0";
        }

        private void TxtBxX_Leave(object sender, EventArgs e)
        {
            if (TxtBxX.Text == "")
            {
                TxtBxX.Text = "0";
            }
        }

        private void TxtBxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && TxtBxX.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void BtnSen_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Sin(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Sin(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Cos(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Cos(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Tan(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Tan(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnCtg_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = 1/Math.Tan(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = 1/Math.Tan(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = 1 / Math.Cos(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = 1 / Math.Cos(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BntCsc_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = 1 / Math.Sin(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = 1 / Math.Sin(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcsen_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Asin(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Asin(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcos_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Acos(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Acos(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcTan_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Atan(a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Atan(a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcCtg_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Atan(1/a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Atan(1/a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcSec_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Acos(1 / a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Acos(1 / a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnArcCsc_Click(object sender, EventArgs e)
        {
            if (RBtnGrados.Checked)
            {
                double a = Convert.ToDouble(TxtBxX.Text);
                double b = Math.Asin(1 / a);
                LblResultado.Text = Convert.ToString(b);
            }
            if (RBtnRadianes.Checked)
            {
                double a = (Convert.ToDouble(TxtBxX.Text) * (Math.PI / 180));
                double b = Math.Asin(1 / a);
                LblResultado.Text = Convert.ToString(b);
            }
        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            TxtBxX.Text = LblResultado.Text;
            LblResultado.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtBxX_Click(object sender, EventArgs e)
        {
            TxtBxX.Text = "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxX.Text = "0";
            LblResultado.Text = "";
        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(Convert.ToDouble(TxtBxX.Text)));
            double c = 1;
            if (TxtBxX.Text.Contains('.'))
            {
                MessageBox.Show("Al intetar calcular el factorial de un numero decimal este se redondeará antes de ser calculado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            for (int b = 1; b <= a; b++)
            {
                c *= b;
            }
            LblResultado.Text = c.ToString();
        }
    }
}
