using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celularPOO
{
    public class Celular
    {
        // atributos
        public string nome = "iPhone 14";
        public string cor = "Branco";
        public string modelo = "Pro";
        public string tamanho = "6.1 polegadas";


        public bool ligado;


        // métodos
        public bool Ligar()
        {
            ligado = true;
            return ligado;
        }

        public bool Desligar()
        {
            ligado = false;
            return ligado;
        }

        public string Discar()
        {
            string ttt = "Não atendida";
            Console.WriteLine(ttt);
            return ttt;
        }

        public string Mensagem()
        {
            string ttt = "Mensagem enviada";
            Console.WriteLine(ttt);
            return ttt;
        }
    }
}