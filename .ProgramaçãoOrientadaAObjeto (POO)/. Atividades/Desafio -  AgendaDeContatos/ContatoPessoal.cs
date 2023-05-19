using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts 
{
    public class ContatoPessoal : Contato , IContatoPessoal
    {
        // propriedades
        public string ?Cpf { get; set; }

        bool IContatoPessoal.ValidarCpf()
        {
            throw new NotImplementedException();
        }
    }
}