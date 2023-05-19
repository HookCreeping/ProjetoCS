// Criar um menu de Agenda contendo o nome de alguma pessoa, telefone e
// email, além de pedir contato pessoal (com cpf) e contato comercial
// (com cnpj). Ao final, adicionar tudo em uma lista, que será a agenda.

using Contacts;

bool working = true;

Agenda _agenda = new Agenda();

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"
A G E N D A

[1] - Adicionar Contato
[2] - Listar Contatos

[0] - Encerrar Programa
");
    Br();

    string opcao = Resposta();
    Br();

    switch (opcao)
    {
        case "1":
            _agenda.Criar();
            break;

        case "2":
            Console.WriteLine($"Selecionado");
            break;

        case "0":
            Console.WriteLine($"Encerrando");
            working = false;
            break;

        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Inválido");
        Console.ForegroundColor = ConsoleColor.Yellow;
            break;
    }

} while (working == true);

Console.ResetColor();



// S H O R T C O D E S
static void Br()
{
    Console.WriteLine($"");
}

static string Resposta()
{
    return Console.ReadLine()!.ToLower();
}