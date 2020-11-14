using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Dados
    {
        Entradas entrada = new Entradas();

        public string gerarDados(string dados)
        {
            foreach (var a in dados)
            {
                switch (a)
                {
                    case '0': entrada.inserir("0"); entrada.vazio = true; break;
                    case '1': entrada.inserir("1"); entrada.vazio = true; break;
                    case '2': entrada.inserir("2"); entrada.vazio = true; break;
                    case '3': entrada.inserir("3"); entrada.vazio = true; break;
                    case '4': entrada.inserir("4"); entrada.vazio = true; break;
                    case '5': entrada.inserir("5"); entrada.vazio = true; break;
                    case '6': entrada.inserir("6"); entrada.vazio = true; break;
                    case '7': entrada.inserir("7"); entrada.vazio = true; break;
                    case '8': entrada.inserir("8"); entrada.vazio = true; break;
                    case '9': entrada.inserir("9"); entrada.vazio = true; break;
                    case ',': entrada.inserir(","); entrada.vazio = true; break;
                    case '+': entrada.operador(); entrada.vazio = false; break;
                    case 'x': entrada.multiplicar(); break;
                    case '/': entrada.dividir(); break;
                    case '-': entrada.operador(); entrada.inserir("-"); entrada.vazio = false; break;
                }

            }

            return (entrada.resultado());

        }
        
        public void clear()
        {
            entrada.clear();
        }
    }
}

