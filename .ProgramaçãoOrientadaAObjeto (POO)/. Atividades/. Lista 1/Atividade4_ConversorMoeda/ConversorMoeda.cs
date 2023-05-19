using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade4_ConversorMoeda
{
    public static class ConversorMoeda
    {
        // propriedades
        public static float valor { get; set; }

        // métodos

        public static float DollarToBrl(float money)
        {
            float dollar = money / 5;
            return dollar;
        }

        public static float BrlToDollar(float money)
        {
            float brl = money * 5;
            return brl;
            }
    }
}