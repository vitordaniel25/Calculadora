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
        public string d = "";
        public string e = "";
        public string f = "";
        public string g = "";
        public string h = "";
        public bool aExists = false;
        public bool bExists = false;
        public bool cExists = false;
        public bool dExists = false;
        public bool eExists = false;
        public bool fExists = false;
        public bool gExists = false;
        public bool hExists = false;
        public bool abMult = false;
        public bool bcMult = false;
        public bool cdMult = false;
        public bool deMult = false;
        public bool efMult = false;
        public bool fgMult = false;
        public bool ghMult = false;
        public bool abDiv = false;
        public bool bcDiv = false;
        public bool cdDiv = false;
        public bool deDiv = false;
        public bool efDiv = false;
        public bool fgDiv = false;
        public bool ghDiv = false;
        public bool vazio = false;

        public void operador()
        {
            if (vazio)
            {
                if (!aExists)
                {
                    aExists = true;
                }
                else if (!bExists)
                {
                    bExists = true;
                }
                else if (!cExists)
                {
                    cExists = true;
                }
                else if (!dExists)
                {
                    dExists = true;
                }
                else if (!eExists)
                {
                    eExists = true;
                }
                else if (!fExists)
                {
                    fExists = true;
                }
                else if (!gExists)
                {
                    gExists = true;
                }
                else if (!hExists)
                {
                    hExists = true;
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
            else if (!dExists)
            {
                d = d + valor;
            }
            else if (!eExists)
            {
                e = e + valor;
            }
            else if (!fExists)
            {
                f = f + valor;
            }
            else if (!gExists)
            {
                g = g + valor;
            }
            else if (!hExists)
            {
                h = h + valor;
            }
        }
        public string resultado()
        {

            Calculos calc = new Calculos();
            string result = calc.resultado(abMult, bcMult, cdMult, deMult, efMult, fgMult, ghMult,
                abDiv, bcDiv, cdDiv, deDiv, efDiv, fgDiv, ghDiv, a, b, c, d, e, f, g, h);
            return (result);
        }

        public void multiplicar()
        {
            if (!aExists)
            {
                abMult = true;
            }
            else if (!bExists)
            {
                bcMult = true;
            }
            else if (!cExists)
            {
                cdMult = true;
            }
            else if (!dExists)
            {
                deMult = true;
            }
            else if (!eExists)
            {
                efMult = true;
            }
            else if (!fExists)
            {
                fgMult = true;
            }
            else if (!gExists)
            {
                ghMult = true;
            }
            operador();
            vazio = false;
        }

        public void dividir()
        {
            if (!aExists)
            {
                abDiv = true;
            }
            else if (!bExists)
            {
                bcDiv = true;
            }
            else if (!cExists)
            {
                cdDiv = true;
            }
            else if (!dExists)
            {
                deDiv = true;
            }
            else if (!eExists)
            {
                efDiv = true;
            }
            else if (!fExists)
            {
                fgDiv = true;
            }
            else if (!gExists)
            {
                ghDiv = true;
            }
            operador();
            vazio = false;
        }


        public void clear()
        {
            a = "";
            b = "";
            c = "";
            d = "";
            e = "";
            f = "";
            g = "";
            h = "";
            aExists = false;
            bExists = false;
            cExists = false;
            dExists = false;
            eExists = false;
            fExists = false;
            gExists = false;
            hExists = false;
            abMult = false;
            bcMult = false;
            cdMult = false;
            deMult = false;
            efMult = false;
            fgMult = false;
            ghMult = false;
            abDiv = false;
            bcDiv = false;
            cdDiv = false;
            deDiv = false;
            efDiv = false;
            fgDiv = false;
            ghDiv = false;
            vazio = false;
        }



    }
}
