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
        Entradas entrada = new Entradas();

        public Form1()
        {
            InitializeComponent();
            Entradas entrada = new Entradas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            txbTela.Text = entrada.resultado();
            label1.Text = entrada.a;
            label2.Text = entrada.b;
            label3.Text = entrada.c;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            entrada.inserir("1");
            txbTela.Text += "1";
            entrada.vazio = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            entrada.inserir("2");
            txbTela.Text += "2";
            entrada.vazio = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            entrada.inserir("3");
            txbTela.Text += "3";
            entrada.vazio = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            entrada.inserir("4");
            txbTela.Text += "4";
            entrada.vazio = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            entrada.inserir("5");
            txbTela.Text += "5";
            entrada.vazio = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            entrada.inserir("6");
            txbTela.Text += "6";
            entrada.vazio = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            entrada.inserir("7");
            txbTela.Text += "7";
            entrada.vazio = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            entrada.inserir("8");
            txbTela.Text += "8";
            entrada.vazio = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            entrada.inserir("9");
            txbTela.Text += "9";
            entrada.vazio = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            entrada.inserir("0");
            txbTela.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            entrada.operador();
            txbTela.Text += "+";
            entrada.vazio = false;

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txbTela.Text += "X";
            if (!entrada.aExists)
            {
                entrada.abMult = true;
            }
            else if (!entrada.bExists)
            {
                entrada.bcMult = true;
            }
            entrada.operador();
            entrada.vazio = false;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txbTela.Text += "/";
            if (!entrada.aExists)
            {
                entrada.abDiv = true;
            }
            else if (!entrada.bExists)
            {
                entrada.bcDiv = true;
            }
            entrada.operador();
            entrada.vazio = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTela.Text = "";
            entrada.a = "";
            entrada.b = "";
            entrada.c = "";
            entrada.aExists = false;
            entrada.bExists = false;
            entrada.cExists = false;
            entrada.abMult = false;
            entrada.bcMult = false;
            entrada.abDiv = false;
            entrada.bcDiv = false;
            entrada.vazio = false;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            
            
            txbTela.Text += "-";
            entrada.operador();
            entrada.inserir("-");
            entrada.vazio = false;
        }
    }
}
