// Faça um programa que o usuário informe o salário recebido e o total gasto.
// Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
// não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto
//  ultrapassar o valor do salário.

// Salario recebido = x, Total gasto = y
// Orçamento Final (OF) = x - y
// Se (OF) > 0, Gastos dentro do orçamento, ou seja, está dentro do limite de gastos.
// Se (OF) <= 0, Orçamento estourado, ou seja, passou dos limites de gastos

Console.WriteLine($"Qual é o seu salário? "); 
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos reais você gastou ultimamente?");
float gastos = float.Parse(Console.ReadLine()!);

float Orçamento = salario - gastos;

if (Orçamento >= 0){
    Console.WriteLine($"Gastos estão dentro do orçamento, mas tenha prudência.");
} else {
    Console.WriteLine($"Orçamento estourado, pare imediatamente de gastar!");
}