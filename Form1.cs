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
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)10: result(); break;
                case (char)48: txbTela.Text += "0"; result(); break;
                case (char)49: txbTela.Text += "1"; result(); break;
                case (char)50: txbTela.Text += "2"; result(); break;
                case (char)51: txbTela.Text += "3"; result(); break;
                case (char)52: txbTela.Text += "4"; result(); break;
                case (char)53: txbTela.Text += "5"; result(); break;
                case (char)54: txbTela.Text += "6"; result(); break;
                case (char)55: txbTela.Text += "7"; result(); break;
                case (char)56: txbTela.Text += "8"; result(); break;
                case (char)57: txbTela.Text += "9"; result(); break;
                case (char)45: if (operador()) { txbTela.Text += "-"; } result(); break;
                case (char)43: if (operador()) { txbTela.Text += "+"; } result(); break;
                case (char)47: if (operador()) { txbTela.Text += "/"; } result(); break;
                case (char)42: if (operador()) { txbTela.Text += "x"; } result(); break;
                case (char)8: apagar(); result(); break;
                case (char)61: result(); break;
                case (char)27: dados.clear(); txbTela.Text = ""; break;


            }
            e.Handled = true;

        }

        private void result()
        {
            btnResultado.Focus();
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
            if (txbTela.Text.Length > 0)
            {
                op = txbTela.Text.Last<char>();
                if ((op.Equals('+')) || (op.Equals('/')) || (op.Equals('x')) || (op.Equals('-')))
                {
                    operador = false;
                }
            }
            else
            {
                operador = false;
            }
            return (operador);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            apagar();
            result();
        }
        private void apagar()
        {
            if (txbTela.Text.Length > 0)
            {
                txbTela.Text = txbTela.Text.Remove(txbTela.Text.Length - 1);
            }
        }
    }
}
