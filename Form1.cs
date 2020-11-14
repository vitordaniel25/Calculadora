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
                case (char)44: if (virgula()) { txbTela2.Text += ","; } result(); break;
                case (char)46: if (virgula()) { txbTela2.Text += ","; } result(); break;
                case (char)48: txbTela2.Text += "0"; result(); break;
                case (char)49: txbTela2.Text += "1"; result(); break;
                case (char)50: txbTela2.Text += "2"; result(); break;
                case (char)51: txbTela2.Text += "3"; result(); break;
                case (char)52: txbTela2.Text += "4"; result(); break;
                case (char)53: txbTela2.Text += "5"; result(); break;
                case (char)54: txbTela2.Text += "6"; result(); break;
                case (char)55: txbTela2.Text += "7"; result(); break;
                case (char)56: txbTela2.Text += "8"; result(); break;
                case (char)57: txbTela2.Text += "9"; result(); break;
                case (char)45: if (operador()) { txbTela2.Text += "-"; } result(); break;
                case (char)43: if (operador()) { txbTela2.Text += "+"; } result(); break;
                case (char)47: if (operador()) { txbTela2.Text += "/"; } result(); break;
                case (char)42: if (operador()) { txbTela2.Text += "x"; } result(); break;
                case (char)8: apagar(); result(); break;
                case (char)61: result(); break;
                case (char)27: dados.clear(); txbTela2.Text = ""; break;


            }
            e.Handled = true;

        }

        private void result()
        {
            btnResultado.Focus();
            txbResultado.Text = dados.gerarDados(txbTela2.Text);
            if (SistemaCheio.sistemaCheio)
            {
                btnSomar.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnDividir.Enabled = false;
            }
            else
            {
                btnSomar.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnDividir.Enabled = true;
            }
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
            txbTela2.Text += "1";
            result();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "2";
            result();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "3";
            result();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "4";
            result();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "5";
            result();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "6";
            result();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "7";
            result();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "8";
            result();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "9";
            result();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbTela2.Text += "0";
            result();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela2.Text += "+";
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela2.Text += "x";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela2.Text += "/";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dados.clear();
            txbTela2.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (operador())
            {
                txbTela2.Text += "-";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (virgula())
            {
                txbTela2.Text += ",";

            }
        }

        private bool operador()
        {
            char op;
            bool operador = true;
            if (txbTela2.Text.Length > 0)
            {
                op = txbTela2.Text.Last<char>();
                if ((op.Equals('+')) || (op.Equals('/')) || (op.Equals('x')) || (op.Equals('-')))
                {
                    operador = false;
                }
            }
            else
            {
                operador = false;
            }
            if (SistemaCheio.sistemaCheio)
            {
                operador = false;
            }
            return (operador);
        }
        private bool virgula()
        {
            char op;
            bool operador = true;
            if (txbTela2.Text.Length > 0)
            {
                op = txbTela2.Text.Last<char>();
                if (op.Equals(','))
                {
                    operador = false;
                }
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
            if (txbTela2.Text.Length > 0)
            {
                txbTela2.Text = txbTela2.Text.Remove(txbTela2.Text.Length - 1);
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ForeColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            txbTela2.BackColor = System.Drawing.Color.RoyalBlue;
            txbTela2.ForeColor = System.Drawing.Color.White;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.Red;
            panel2.BackColor = System.Drawing.Color.Red;
            txbTela2.BackColor = System.Drawing.Color.Black;
            txbTela2.ForeColor = System.Drawing.Color.Red;
        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.Lime;
            panel2.BackColor = System.Drawing.Color.Lime;
            txbTela2.BackColor = System.Drawing.Color.Black;
            txbTela2.ForeColor = System.Drawing.Color.Lime;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Purple;
            this.ForeColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            txbTela2.BackColor = System.Drawing.Color.Purple;
            txbTela2.ForeColor = System.Drawing.Color.White;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
            this.ForeColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            txbTela2.BackColor = System.Drawing.Color.Orange;
            txbTela2.ForeColor = System.Drawing.Color.White;
        }
    }
}
