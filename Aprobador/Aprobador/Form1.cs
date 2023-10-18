using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprobador
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
            double Nota = Convert.ToDouble(TxtBxNota.Text);
            if (Nota>0 && Nota<10)
            {
                if (Nota >=5)
                {
                    LblMensaje.Text = "Aprobado";
                    LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#06B050");
                    Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#06B050");
                }
                else
                {
                    LblMensaje.Text = "Reprobado";
                    LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                    Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                }
            }
            else
            {
                LblMensaje.Text = "Nota inválida";
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
