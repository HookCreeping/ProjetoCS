using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public interface IAgenda
    {
        // métodos
        public void Adicionar(Contato _contato);

        public void Listar();
    }
}