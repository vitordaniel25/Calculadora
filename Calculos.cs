using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculos
    {
        double valorA;
        double valorB;
        double valorC;
        double valorD;
        double valorE;
        double valorF;
        double valorG;
        double valorH;
        double valorFinal;
        string result = "";
        public string resultado( bool AbMult, bool BcMult, bool CdMult, bool DeMult, bool EfMult, bool FgMult, bool GhMult,
            bool AbDiv, bool BcDiv, bool CdDiv, bool DeDiv, bool EfDiv, bool FgDiv, bool GhDiv, 
            string ValorA, string ValorB, string ValorC, string ValorD,
            string ValorE, string ValorF, string ValorG, string ValorH)
        {
            double.TryParse(ValorA, out valorA);
            double.TryParse(ValorB, out valorB);
            double.TryParse(ValorC, out valorC);
            double.TryParse(ValorD, out valorD);
            double.TryParse(ValorE, out valorE);
            double.TryParse(ValorF, out valorF);
            double.TryParse(ValorG, out valorG);
            double.TryParse(ValorH, out valorH);
            if (AbMult)
            {
                valorB = valorA * valorB;
                valorA = 0;
            }
            if (BcMult)
            {
                valorC = valorC * valorB;
                valorB = 0;
            }
            if (CdMult)
            {
                valorD = valorC * valorD;
                valorC = 0;
            }
            if (DeMult)
            {
                valorE = valorD * valorE;
                valorD = 0;
            }
            if (EfMult)
            {
                valorF = valorE * valorF;
                valorE = 0;
            }
            if (FgMult)
            {
                valorG = valorF * valorG;
                valorF = 0;
            }
            if (GhMult)
            {
                valorH = valorG * valorH;
                valorG = 0;
            }

            if (AbDiv)
            {
                valorB = valorA / valorB;
                valorA = 0;
            }
            if (BcDiv)
            {
                valorC = valorC / valorB;
                valorB = 0;
            }
            if (CdDiv)
            {
                valorD = valorC / valorD;
                valorC = 0;
            }
            if (DeDiv)
            {
                valorE = valorD / valorE;
                valorD = 0;
            }
            if (EfDiv)
            {
                valorF = valorE / valorF;
                valorE = 0;
            }
            if (FgDiv)
            {
                valorG = valorF / valorG;
                valorF = 0;
            }
            if (GhDiv)
            {
                valorH = valorG / valorH;
                valorG = 0;
            }


            valorFinal = valorA + valorB + valorC + valorD + valorE + valorF + valorG + valorH;
            result = "" + valorFinal;
            return (result);
        }


    }
}
