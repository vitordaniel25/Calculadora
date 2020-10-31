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
        Dados dados = new Dados();
        public Form1()
        {
            InitializeComponent();
        }


        private void result()
        {
            txbResultado.Text = dados.gerarDados(txbTela.Text);
            dados.clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            result();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbTela.Text += "1";
            result();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbTela.Text += "2";
            result();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbTela.Text += "3";
            result();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbTela.Text += "4";
            result();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbTela.Text += "5";
            result();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbTela.Text += "6";
            result();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbTela.Text += "7";
            result();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbTela.Text += "8";
            result();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbTela.Text += "9";
            result();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbTela.Text += "0";
            result();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela.Text += "+";
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela.Text += "x";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela.Text += "/";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dados.clear();
            txbTela.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela.Text += "-";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {           
            txbTela.Text += ",";
          
            
        }

        private bool operador()
        {
            char op = 'a';
            bool operador = true;
            op = txbTela.Text.Last<char>();
            if ((op.Equals('+'))|| (op.Equals('/')) || (op.Equals('x')) || (op.Equals('-')))
            {
                operador = false;
            }
            return (operador);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txbTela.Text.Length > 0)
            {
                txbTela.Text = txbTela.Text.Remove(txbTela.Text.Length - 1);
            }
            result();
            
            

        }
    }
}
