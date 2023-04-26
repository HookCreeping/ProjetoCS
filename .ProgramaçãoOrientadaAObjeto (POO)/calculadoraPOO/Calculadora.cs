using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadoraPOO
{
    public class Calculadora
    {
        // atributos
        public float x;
        public float y;
        public string digito;


        // métodos

        public float Operacao(string ttt, float x, float y)
        {
            float total;
            string aviso = "Incorrect Character";

            switch (ttt)
            {
                case "+":
                    total = x + y;
                    return total;

                case "-":
                    total = x - y;
                    return total;

                case "*":
                    total = x * y;
                    return total;

                case "/":
                    total = x / y;
                    return total;

                default:
                Console.WriteLine(aviso);
                total = 0 * 0;
                    return total;
            }
        }
    }
}