// calculadora

// Algoritmo

// 1- informar opecaçao
// 2- informar o primeiro numero
// 3- informar o segundo numero
// 4- processar os dados
// 5- exibir o resultado

// entrada
Console.WriteLine(@$"
----------------------------------------
|        PROGRAMA DE CALCULADORA       |
|                                      |
|                                      |
|          Informe a operação          |
|                                      |
|                                      |
|                                      |
|         (+) adição                   |
|         (-) subtração                |
|         (*) multiplicação            |
|         (/) divisão                  |
|                                      |
----------------------------------------
");

char operacao = char.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

double resultado = 0;

switch (operacao) {
    case '+':
    resultado = (num1 + num2);
    Console.WriteLine($"Resultado: {resultado}");
    break;

    case '-':
    resultado = (num1 - num2);
    Console.WriteLine($"Resultado: {resultado}");
    break;

    case '*':
    resultado = (num1 * num2);
    Console.WriteLine($"Resultado: {resultado}");
    break;
    
    case '/':
    resultado = (num1 / num2);
    Console.WriteLine($"Resultado: {resultado}");
    break;

    default:
    Console.WriteLine($"Operação Inválida");
    break;
}