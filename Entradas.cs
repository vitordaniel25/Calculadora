using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Entradas
    {
        public string a = "";
        public string b = "";
        public string c = "";
        public bool aExists = false;
        public bool bExists = false;
        public bool cExists = false;
        public bool abMult = false;
        public bool bcMult = false;
        public bool abDiv = false;
        public bool bcDiv = false;
        public bool vazio = false;

        public void operador()
        {
            if (vazio)
            {
                if (!aExists && !bExists && !cExists)
                {
                    aExists = true;
                }
                else if (aExists && !bExists && !cExists)
                {
                    bExists = true;
                }
            }
        }
        public void inserir(string valor)
        {
            if (!aExists)
            {
                a = a + valor;
            }
            else if (!bExists)
            {
                b = b + valor;
            }
            else if (!cExists)
            {
                c = c + valor;
            }
        }
        public string resultado()
        {

            Calculos calc = new Calculos();
            string result = calc.resultado(abMult, bcMult, abDiv, bcDiv, a, b, c);
            return (result);
        }



    }
}
