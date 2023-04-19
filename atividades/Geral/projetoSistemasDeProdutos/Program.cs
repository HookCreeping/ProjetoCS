// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10
// produtos pelo console:

// Os produtos terão os seguintes atributos:
// . string Nome
// . float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:

// . CadastrarProduto;
// . ListarProdutos;
// . MostrarMenu;

// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua 
// criatividade.


// Algoritmo: 

// Laço de repetição for para os dez produtos
// Do while para adicionar ou não os produtos;
// Usar switch nas opções 1-Cadastro | 2-Listagem | 0-Terminar o programa





// funções: 
static bool Resposta(string ttt, bool u01)
{
    if ((ttt == "n") || (ttt == "s"))
    {
        u01 = true;
    }
    else
    {
        Console.WriteLine($"Caracter incorreto");
    }

    return u01;
}

static bool Parar(string ttt, bool u01)
{
    if (ttt == "s")
    {
        u01 = true;
    }
    else if (ttt == "n")
    {
        u01 = true;
    }
    else
    {
        Console.WriteLine($"Digito incorreto");
    }

    return u01;
}
// declarar as variáveis:
string[] produto = new string[10];
string[] preco = new string[10];
bool[] promocao = new bool[10];

string opcao;
string promo;
string simNao;

bool parar;


// começo do programa
do
{

    //criar menu de opções 
    Console.WriteLine($"MENU DE OPÇÕES: ");
    Console.WriteLine(@"
    Selecione uma das opções: 
    [1] - Cadastrar produto;
    [2] - Listar produtos;
    [0] - Terminar o programa;
    ");

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":

            bool resposta = false;

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Informe o nome do produto:");
                    produto[i] = Console.ReadLine()!;

                    Console.WriteLine($"Informe o preço do produto");
                    preco[i] = Console.ReadLine()!;

                    do
                    {
                        parar = false;
                        Console.WriteLine($"O produto está em promoção? S/N");
                        promo = Console.ReadLine()!.ToLower();

                        if (promo == "s") {
                            promocao[i] = true;
                        }

                        parar = Parar(promo, parar);
                    } while (parar == false);

                }
                Console.WriteLine(@$"
                    Refazer o cadastro? S/N");
                simNao = Console.ReadLine()!.ToLower();

                resposta = Resposta(simNao, resposta);

            } while (resposta != true);

            break;

        case "2":

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(@$"
                ***************************
                Listagem:
                
                Produto: {produto[i]}
                Preço: {preco[i]}
                Promoção: {promocao[i]}");
            }

            break;

        case "0":
            Console.WriteLine($"Fim do programa");
            break;

        default:
            Console.WriteLine($"Caracter inválido");
            break;
    }

} while (opcao != "0");