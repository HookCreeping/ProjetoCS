using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public abstract class Contato
    {
        // propriedades
        public string ?Nome { get; set; }
        public string ?Telefone { get; set; }
        public string ?Email { get; set; }

        // construtores
        public Contato()
        {
            
        }

        public Contato(string _nome, string _telefone, string _email)
        {
            Nome = _nome;
            Telefone = _telefone;
            Email = _email;
        }
    }
}