//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"
    SELECIONE A SUA OPÇÃO

    1 - Coca
    2 - Pepsi
    3 - Fanta
    4 - Guaraná

    Digite o número da sua opção
");

int pedido = int.Parse(Console.ReadLine()!.ToLower());

switch (pedido) {
    case 1:
    Console.WriteLine($"Gostaria de gelo em sua bebida?");
    string resposta1 = Console.ReadLine()!.ToLower();
    if (resposta1 == "sim") {
        Console.WriteLine($"1 Coca com gelo");
        
    } else {
        Console.WriteLine($"1 Coca sem gelo");
        
    }
    break;

    case 2:
    Console.WriteLine($"Gostaria de gelo em sua bebida?");
    string resposta2 = Console.ReadLine()!.ToLower();
    if (resposta2 == "sim") {
        Console.WriteLine($"1 Pepsi com gelo");
        
    } else {
        Console.WriteLine($"1 Pepsi sem gelo");
        
    }
    break;

    case 3:
Console.WriteLine($"Gostaria de gelo em sua bebida?");
    string resposta3 = Console.ReadLine()!.ToLower();
    if (resposta3 == "sim") {
        Console.WriteLine($"1 Fanta com gelo");
        
    } else {
        Console.WriteLine($"1 Fanta sem gelo");
        
    }
    break;

    case 4:
    Console.WriteLine($"Gostaria de gelo em sua bebida?");
    string resposta4 = Console.ReadLine()!.ToLower();
    if (resposta4 == "sim") {
        Console.WriteLine($"1 Guaraná com gelo");
        
    } else {
        Console.WriteLine($"1 Guaraná sem gelo");
        
    }
    break;

    default:
    Console.WriteLine($"Essa bebida está indisponível");
    break;
}