using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2___ProjetoDeProdutos
{
    public class Produto
    {
        // atributos e propriedades
        public string? Codigo { get; private set; }
        public string? NomeProduto { get; private set; }
        public string? Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string? CadastradoPor { get; private set; }

        public Marca _marca = new Marca();
        List<Produto> listaDeProdutos = new List<Produto>();

        // métodos
        public void Cadastrar() // $
        {
            Produto p = new Produto();
            Usuario user = new Usuario();

            Console.WriteLine($"Código do produto: ");
            p.Codigo = Console.ReadLine()!;

            Console.WriteLine($"Nome do produto: ");
            p.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Preço do produto: ");
            p.Preco = Console.ReadLine()!;

            p.DataCadastro = DateTime.Now;
            p.CadastradoPor = user.Nome;

            listaDeProdutos.Add(p);
        }

        public void Listar() // $
        {
            if (listaDeProdutos.Count == 0) // $
            {
                Console.WriteLine($"Não há produtos para listar");

            }
            else // $
            {
                foreach (var item in listaDeProdutos) // $
                {
                    Console.WriteLine(@$"
-------------------------------------------------
Produto número {listaDeProdutos.IndexOf(item) + 1}

{item.Codigo}

Nome: {item.NomeProduto}
Preço: {item.Preco}

Data: {item.DataCadastro}
Cadastrado por: {item.CadastradoPor}
                ");
                }
            }
        }

        public void Deletar(string _codigo) // $
        {
            Produto pr = listaDeProdutos.Find(x => x.Codigo == _codigo)!;

            listaDeProdutos.Remove(pr);
        }
    }
}