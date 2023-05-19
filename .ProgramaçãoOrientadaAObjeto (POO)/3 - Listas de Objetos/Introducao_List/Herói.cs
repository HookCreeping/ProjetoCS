using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaObjeto
{
    public class Heroi
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public float forca { get; set; }

        // métodos

        public Heroi(int cod, string nom, float forc)
        {
            codigo = cod;
            nome = nom;
            forca = forc;
        }
    }
}
