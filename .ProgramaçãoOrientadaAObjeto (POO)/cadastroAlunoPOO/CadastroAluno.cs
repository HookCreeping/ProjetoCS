using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroAlunoPOO
{
    public class CadastroAluno
    {
        // atributos
        public string ? nome;
        public string ? idade;
        public string ? rg;

        public bool bolsa;

        public float mensal;
        public float media;

        public float calcMedia;
        // métodos

        public float Mensalidade()
        {
            if ((media >= 8) && (bolsa == true))
            {
                calcMedia = mensal - (50 * (mensal / 100));
                return calcMedia;
            }
            else if (((media >= 6) && (media < 8)) && (bolsa == true))
            {
                calcMedia = mensal - (30 * (mensal / 100));
                return calcMedia;
            }
            else
            {
                return mensal;
            }
        }
    }
}