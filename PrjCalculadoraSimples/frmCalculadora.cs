using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadoraSimples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        public Double somar(String simbolo)
        {
            String val1 = txtVal1.Text;
            String val2 = txtVal2.Text;
            Double resultado = 0;

            try
            {

                Double num1 = Convert.ToDouble(val1.Replace(".",",")); //replace serve para troca de caracteres
                Double num2 = Convert.ToDouble(val2.Replace(".", ","));

                if (simbolo == "+")
                {
                    resultado = num1 + num2;
                    txtResultado.Text = resultado.ToString();
                    txtVal1.Clear();
                    txtVal2.Clear();
                   
                }
                else if (simbolo == "-")
                {
                    resultado = num1 - num2;
                    txtResultado.Text = resultado.ToString();
                    txtVal1.Clear();
                    txtVal2.Clear();

                }
                else if (simbolo == "×")
                {
                    resultado = num1 * num2;
                    txtResultado.Text = resultado.ToString();
                    txtVal1.Clear();
                    txtVal2.Clear();
                }
                else
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString();
                    txtVal1.Clear();
                    txtVal2.Clear();

                }

            }
            catch(Exception)//não acrescentado variavel erro, por não usar
            {
                txtResultado.Text = "Valor inválido!";
                
            }
         

            return resultado;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
           
            somar("+");
            
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            somar("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            somar("×");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            somar("÷");
        }


    }
}
