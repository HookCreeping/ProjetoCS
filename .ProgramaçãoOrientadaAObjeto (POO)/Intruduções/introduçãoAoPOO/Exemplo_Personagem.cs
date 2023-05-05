// Vamos criar uma classe contenha um personagem:

// padrão do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// nome da pasta
namespace introduçãoAoPOO
{
    // aqui está a classe
    public class Exemplo_Personagem
    {
        // o personagem vai ser o Tony Stark (homem de ferro)

        // ATRIBUTOS, como Nome, Idade, Armadura e IA

        public string nome = "Tony Stark";
        // ^ Agora se usa o nome "public" ao invés de "static"
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string IA = "Jarvis";


        // além dos atributos, temos o COMPORTAMENTO, vindo com MÉTODOS

        public void Atacar()
        {
            Console.WriteLine("O personagem atacou");
        }
    }

    public class NovoPersonagem {
        public string nome;

        public string idade;

        public string armadura;

        public string IA;
    }
}