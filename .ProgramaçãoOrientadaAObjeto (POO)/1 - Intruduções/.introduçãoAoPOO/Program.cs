// Vamos iniciar o estudo de POO (Programação Orientada a Objeto)

// Existem termos genéricos que são utilizados para armazenar outros
// termos de uma programação. Esses são chamados de Classes. 

// Uma classe é o todo, como se fosse uma lista de características e
// atributos para o que será armazenado dentro dela. São genéricas.
// O que é armazenado dentro da classe são Objetos

// Objetos são itens que possuem características e atributos que
// podem ser gerados, assim como a classe. Porém, a diferença entre
// esses dois é que objetos não são termos genéricos, ou seja, são 
// mais precisos do que as classes; Exemplo: Classes de animais, como
// Mamíferos, Aves... 





// C R I A N D O   U M A   C L A S S E 

// Primeira coisa, devemos criar um novo arquivo da atual linguagem
// de programação que, de certa forma, SAIA do Program (classe atual).

// Clique em botão direito na pasta do code e Crie um novo C#, e depois
// selecione "classe".


// Com a classe criada, é hora de Instancia-la (cria-la em outro
// lugar).


using introduçãoAoPOO;
// ^ !é necessário usar o "using" para localizar/ importar 
// a pasta que a classe se encontra!;

// instanciar um objeto da classe Exemplo_Personagem
Exemplo_Personagem tony = new Exemplo_Personagem();

Console.WriteLine(tony.nome);

// A classe agora é reconhecida como "tony", sendo transformada em
// um método. Agora, "tony" terá os valores da classe. No caso, ele
// vai imprimir o "nome" dentro de "tony". Confuso, né? De um 
// 'dotnet run' para ver o que acontece!

// Viu? Ele escreveu o nome que está na classe de OUTRO LUGAR;

// Vamos receber tudo desse personagem (até os métodos):

Console.WriteLine($"");
Console.WriteLine(@$"
{tony.nome}
{tony.idade}
{tony.armadura}
{tony.IA}
");


tony.Atacar();

Console.WriteLine(@$"






");

Console.WriteLine($"Agora é a sua vez: Faça/ Insira um personagem!");
Console.WriteLine($"");

NovoPersonagem fulaninho = new NovoPersonagem();

Console.WriteLine($"NOME DO PERSONAGEM");
fulaninho.nome = Console.ReadLine()!;
Console.WriteLine($"");

Console.WriteLine($"IDADE DO PERSONAGEM");
fulaninho.idade = Console.ReadLine()!;
Console.WriteLine($"");

Console.WriteLine($"ARMADURA DO PERSONAGEM");
fulaninho.armadura = Console.ReadLine()!;
Console.WriteLine($"");

Console.WriteLine($"IA DO PERSONAGEM");
fulaninho.IA = Console.ReadLine()!;
Console.WriteLine($"");

