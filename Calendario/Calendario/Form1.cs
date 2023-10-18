using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class MonthChecker : Form
    {
        public MonthChecker()
        {
            InitializeComponent();
        }
        public bool CaracterChecker(char caracter)
        {
            char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return caracteres.Contains(caracter) || char.IsControl(caracter);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CaracterChecker(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int Mes = Convert.ToInt16(TxtBxMes.Text);
            if (Mes > 0 && Mes < 13)
            {
                switch (Mes)
                {
                    case 1:
                        LblMensaje.Text = "Enero";
                        break;
                    case 2:
                        LblMensaje.Text = "Febrero";
                        break;
                    case 3:
                        LblMensaje.Text = "Marzo";
                        break;
                    case 4:
                        LblMensaje.Text = "Abril";
                        break;
                    case 5:
                        LblMensaje.Text = "Mayo";
                        break;
                    case 6:
                        LblMensaje.Text = "Junio";
                        break;
                    case 7:
                        LblMensaje.Text = "Julio";
                        break;
                    case 8:
                        LblMensaje.Text = "Agosto";
                        break;
                    case 9:
                        LblMensaje.Text = "Septiembre";
                        break;
                    case 10:
                        LblMensaje.Text = "Octubre";
                        break;
                    case 11:
                        LblMensaje.Text = "Noviembre";
                        break;
                    case 12:
                        LblMensaje.Text = "Diciembre";
                        break;
                }
            }
            else
            {
                LblMensaje.Text = "El número ingresado no corresponde a un mes";
            }
        }
    }
}
