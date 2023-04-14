// 3 - Faça um algoritmo para ler: a descrição do produto (nome),
// a quantidade adquirida e o preço unitário. Calcular e escrever o
// total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), 
// sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%

// Dica: utilize if / else if / else



// algoritmo

// Nome = string
// Quantidade = int
// Preço = float

Console.WriteLine($"Qual produto foi comprado?");
string nomeProduto = Console.ReadLine()!;
Console.WriteLine($"");

Console.WriteLine($"Quantas unidades do produto foram compradas?");
int quantidadeProduto = int.Parse(Console.ReadLine()!);
Console.WriteLine($"");
int porcentagem = 0;

Console.WriteLine($"Qual é o preço de cada unidade do produto: {nomeProduto}?");
float precoProduto = float.Parse(Console.ReadLine()!);
Console.WriteLine($"");

Console.WriteLine(@$" O preço de {quantidadeProduto}x {nomeProduto} é de {Math.Round( ValorFinal(quantidadeProduto, porcentagem, precoProduto), 2)}");




static float ValorFinal(int n1, int n2, float n3) {
    if (n1 <= 5) {
        n2 = +2;
    } else if ((n1 > 5) && (n1 <= 10)) {
        n2 = +3;
    } else {
        n2 = +5;
    }

    float ValorFinal = n1 * (n3 - (n2 * (n3 / 100)));
    return ValorFinal;
}