using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public class ContatoComercial : Contato , IContatoComercial
    {
        // propriedades
        public string ?Cnpj { get; set; }

        public bool ValidarCnpj()
        {
            throw new NotImplementedException();
        }
    }
}