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
        double valorFinal;
        string result = "";
        public string resultado(bool AbMult, bool BcMult, bool AbDiv, bool BcDiv, string ValorA, string ValorB, string ValorC)
        {
            double.TryParse(ValorA, out valorA);
            double.TryParse(ValorB, out valorB);
            double.TryParse(ValorC, out valorC);
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

            valorFinal = valorA + valorB + valorC;
            result = "" + valorFinal;
            return (result);
        }

       
    }
}
