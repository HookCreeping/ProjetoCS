// criar uma classe Produto com propriedades:

// . int codigo
// . string nome
// . float preco

// criar um construtor vazio
// criar um construtor completo

using ListaObjeto;

List<Heroi> hero = new List<Heroi>();

hero.Add(new Heroi(123, "Pedro CodigoDeBarras", 12.53f));

hero.Add(new Heroi(321, "Ednaldo Trakinagens", 312.72f));

Heroi pedro = new Heroi(0987654323, "Pedro CodigoDeBarras UltraIncrível", 123.4321f);

hero.Add(pedro);

foreach (var status in hero)
{

    Console.WriteLine(@$"
    Herói {hero.IndexOf(status) + 1}
    Código: {status.codigo}
    Nome: {status.nome}
    Força: {status.forca}
    
    ");
}


Heroi heroiEscolhido = hero.Find(x => x.codigo == 0987654323)!;

int index = hero.IndexOf(heroiEscolhido);

heroiEscolhido.forca = 99999999.10f;

hero.RemoveAt(index);

hero.Insert(index, heroiEscolhido);

Console.WriteLine(@$"
Heroi Escolhido:
{heroiEscolhido.nome}

Nova força:
{heroiEscolhido.forca}
");
