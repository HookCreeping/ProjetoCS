using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2___ProjetoDeProdutos
{
    public class Marca
    {
        // atributos e propriedades
        public string? Codigo { get; private set; } 
        public string? NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public List<Marca> listaMarcas = new List<Marca>();

        // métodos
        public void Cadastrar() // $
        {
            Marca m = new Marca();

            Console.WriteLine($"Código do marca: ");
            m.Codigo = Console.ReadLine()!;

            Console.WriteLine($"Nome da marca: ");
            m.NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Preço do marca: ");

            m.DataCadastro = DateTime.Now;

            listaMarcas.Add(m);
        }

        public void Listar() // $
        {
            if (listaMarcas.Count == 0) // $
            {
                Console.WriteLine($"Não há marcas para listar");
                
            }
            else // $
            {
                foreach (var item in listaMarcas) // $
                {
                    Console.WriteLine(@$"
-------------------------------------------------
Marca número {listaMarcas.IndexOf(item) + 1}

{item.Codigo}

Nome: {item.NomeMarca}

Data: {item.DataCadastro}
                ");
                }
            }
            
        }

        public void Deletar(string _codigo) // $
        {
            Marca ma = listaMarcas.Find(y => y.Codigo == _codigo)!;
            listaMarcas.Remove(ma);
        }
    }
}