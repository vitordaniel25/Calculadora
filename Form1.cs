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
        bool op = true; //Pode inserir operador?
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            txbTela.Text = dados.gerarDados(txbTela.Text);
            dados.clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbTela.Text += "1";
            op = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbTela.Text += "2";
            op = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbTela.Text += "3";
            op = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbTela.Text += "4";
            op = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbTela.Text += "5";
            op = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbTela.Text += "6";
            op = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbTela.Text += "7";
            op = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbTela.Text += "8";
            op = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbTela.Text += "9";
            op = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbTela.Text += "0";
            op = true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (op)
            {
                txbTela.Text += "+";
                op = false;
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (op)
            {
                txbTela.Text += "x";
                op = false;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (op)
            {
                txbTela.Text += "/";
                op = false;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dados.clear();
            txbTela.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (op)
            {
                txbTela.Text += "-";
                op = false;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txbTela.Text += ",";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txbTela.Text.Length > 0)
            {
                txbTela.Text = txbTela.Text.Remove(txbTela.Text.Length - 1);
            }
        }
    }
}
