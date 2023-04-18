// Criar uma aplicação para uma agência de turismo, no qual deveremos 
// registrar passagens aéreas com os seguintes dados: Nome do passageiro, 
// Origem, Destino e Data do Voo de 5 passageiros.

// . Antes de entrar no sistema faça um esquema do qual o usuário só 
// possa acessar o menu se a senha for igual à "incorreta".
// . O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).


// ALGORITMO:

// . São 5 pessoas
// . A senha deve vir primeiro. Ela será: "incorreta";
// . Depois da senha, abrir o que seria o menu; 
// . O menu trá as segunites condições: 1(Cadastrar), 2(Listar) e
// 0(Sair);
// . Após o feito, pedir os dados: Nome | Destino | Data;


string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

// Senha

Console.WriteLine($"Insira a senha: ");
bool acesso = false;
while (acesso == false)
{
    string senha = Console.ReadLine()!.ToLower();

    switch (senha)
    {
        case "incorreta":
            Br();
            Console.WriteLine($"ACESSO PERMITIDO");
            Br();

            acesso = true;
            break;

        default:
            Br();
            Console.WriteLine($"ACESSO NEGADO! A SENHA É INCORRETA!");
            break;
    }
}

for (int pessoas = 0; pessoas < 5; pessoas++)
{
    // Menu
    bool cadastrar = false;
    bool listar = false;

    Console.WriteLine($@"Que ação você gostaria de realizar?");
    bool menu = false;


    while (menu == false)
    {
        Br();
        Console.WriteLine(@$"
        1- Cadastrar passagem;
        2- Listar passagens;
        0- Sair");

        int acao = int.Parse(Console.ReadLine()!);

        switch (acao)
        {
            case 1:
                Br();
                Console.WriteLine($"Ação escolhida: Cadastrar passagem");
                cadastrar = true;
                menu = true;

                break;

            case 2:
                Br();
                Console.WriteLine($"Ação escolhida: Listar passagens");
                listar = true;
                menu = true;
                break;

            case 0:
                Br();
                Console.WriteLine($"Tem certeza que quer sair? S/N");
                char NouS = char.Parse(Console.ReadLine()!.ToLower());

                if (NouS == 's')
                {
                    menu = true;
                }
                else if ((NouS != 's') && (NouS != 'n'))
                {
                    Br();
                    Console.WriteLine($"Caracter inválido");
                }
                else
                {
                    Br();
                }
                break;

            default:
                Console.WriteLine($"Caracter inválido");
                break;
        }

        // Entrada de dados

        if (cadastrar == true)
        {
            Br();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Nome: ");
                nome[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Origem: ");
                origem[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Destino: ");
                destino[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Data: ");
                data[pessoas] = Console.ReadLine()!;

            }
            Br();

        }
        else if (listar == true)
        {
            Br();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Nome: ");
                nome[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Origem: ");
                origem[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Destino: ");
                destino[pessoas] = Console.ReadLine()!;

                Br();

                Console.WriteLine($"Data: ");
                data[pessoas] = Console.ReadLine()!;

            }
            Br();

        }
        else
        {
            Br();
            Br();
        }
    }
}

for (var i = 0; i < 5; i++)
{
    Console.WriteLine(@$"
    {nome[i]} - {origem[i]}
    Destino: {destino[i]} - Data: {data[i]}");

}



//métodos
static string Br()
{
    Console.WriteLine("");
    return "";
}


















