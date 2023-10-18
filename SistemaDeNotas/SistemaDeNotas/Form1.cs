using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBxNota_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && TxtBxNota.Text.Contains('.'))
            {
                e.Handled = true;
            }*/
        }
        public bool CaracterChecker(char caracter)
        {
            char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

            return caracteres.Contains(caracter) || char.IsControl(caracter);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && TxtBxNota.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            double Nota = Convert.ToDouble(TxtBxNota.Text);
            if (Nota < 0 || Nota > 10 || TxtBxNota.Text == "")
            {

                LblMensaje.Text = "Nota no valida";
            }
            else
            {
                if (Nota == 10)
                {

                    LblMensaje.Text = "Matricula de honor";
                    LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#06B050");
                    Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#06B050");

                }
                else
                {
                    if (Nota >= 9)
                    {

                        LblMensaje.Text = "Sobresaliente";
                        LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#5FA64B");
                        Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#5FA64B");
                    }
                    else
                    {
                        if (Nota >= 7)
                        {

                            LblMensaje.Text = "Notable";
                            LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#A08F41");
                            Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#A08F41");
                        }
                        else
                        {
                            if (Nota >= 6)
                            {

                                LblMensaje.Text = "Bien";
                                LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#D26C31");
                                Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#D26C31");
                            }
                            else
                            {
                                if (Nota >= 5)
                                {

                                    LblMensaje.Text = "Suficiente";
                                    LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0411E");
                                    Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0411E");
                                }
                                else
                                {
                                    LblMensaje.Text = "Reprobado";
                                    LblTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");
                                    Title.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0201");

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
