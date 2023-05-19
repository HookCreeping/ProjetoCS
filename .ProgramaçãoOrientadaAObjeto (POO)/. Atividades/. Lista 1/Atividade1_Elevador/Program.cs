// Crie uma classe denominada Elevador para armazenar as informações 
// de um elevador dentro de um prédio. A classe deve armazenar o andar 
// atual (térreo = 0), total de andares no prédio (desconsiderando o 
// térreo), capacidade do elevador e quantas pessoas estão presentes 
// nele. A classe deve também disponibilizar os seguintes métodos:

// . Inicializa : que deve receber como parâmetros a capacidade do
// elevador e o total de andares no prédio (os elevadores sempre começam
// no térreo e vazio);
// . Entrar : para acrescentar uma pessoa no elevador (só deve 
// acrescentar se ainda houver espaço);
// . Sair : para remover uma pessoa do elevador (só deve remover se 
// houver alguém dentro dele);
// . Subir : para subir um andar (não deve subir se já estiver no último
// andar);
// . Descer : para descer um andar (não deve descer se já estiver no
// térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using Atividade1_Elevador;

Elevador elv = new Elevador();



bool reset = false;




Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine($"Elevador");

Console.ResetColor();

Br();
Br();

elv.Inicializa();

do
{
    Console.WriteLine(@$"
    {elv.andarAtual}o Andar
    {elv.capacidade} pessoas
    
    Acão do elevador:
    
    [1] Subir
    [2] Descer
    [3] Entrar alguém
    [4] Sair alguém
    
    [0] Fechar programa");

    string resposta = Console.ReadLine()!;

    switch (resposta)
    {
        case "1":
            elv.Subir();
            break;

        case "2":
            elv.Descer();
            break;

        case "3":
            elv.Entrar();
            break;

        case "4":
            elv.Sair();
            break;

        case "0":
            reset = true;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"DÍGITO INVÁLIDO");
            Console.ResetColor();
            break;
    }

} while (reset == false);

Console.WriteLine($"Obrigado, volte sempre!");



// S H O R T C O D E S

static string Br()
{
    Console.WriteLine($"");
    return "";
}