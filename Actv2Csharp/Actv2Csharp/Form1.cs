using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actv2Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta=0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            if (OptSuma.Checked)
            {
                respuesta = num1 + num2;
            }
            if (OptResta.Checked)
            {
                respuesta = num1 - num2;
            }
            if (OptMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }
            if (OptDivision.Checked)
            {
                respuesta = num1 / num2;
            }
            if (OptExponenciacion.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }
            if (OptPorcentaje .Checked)
            {
                respuesta = (num1 / num2) * 0.10;
            }
            if (OptFactorial.Checked)
            {
                int factorial = (int)num1;
                for (int i = (int)num1 - 1; i > 1; i--)
                {
                    factorial *= i;
                }
                respuesta = factorial;

            }
            lblRespuesta.Text = "Respuesta = " + respuesta;

            if (OptPrimo.Checked)
            {
                int i = 1, acum = 0;
                while (i <= num1 && acum < 3)
                {
                    if (num1 % i == 0)
                    {
                        acum++;
                    }
                    i++;
                }
                if (acum == 2)
                {
                    lblRespuesta.Text = "Respuesta: " + num1 + " es primo.";
                }
                else
                {
                    lblRespuesta.Text = "Respuesta: " + num1 + " NO es primo.";
                }
            }
                    

        }

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
                case 4:
                    int factorial = (int)num1;
                    for (int i = (int)num1 - 1; i > 1; i--)
                    {
                        factorial *= i;
                    }
                    respuesta = factorial;
                    break;
            }
            lblRespuesta.Text = "Respuesta =" + respuesta;
            }
        }
    }
