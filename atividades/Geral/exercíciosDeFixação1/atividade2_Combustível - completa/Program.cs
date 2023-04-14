// Um posto está vendendo combustíveis com a seguinte 
// tabela de descontos:

// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo
// de combustível (codificado da seguinte forma: A-álcool, G-gasolina),
// calcule e imprima o valor a ser pago pelo cliente sabendo-se que o
// preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é
// R$ 4,90.


// Dica: utilize switch case e funções/métodos para otimizar
// o algorítimo.

// algoritmo:

// . preço litro Gasolina = x * 5,30 | preço litro Alcool = x * 4,90
// . se x <= 20 litros, desconto de 3-4% cada litro, ou x(preço - 3-4%)
// . se x > 20 litros, desconto de 5-6 cada litro, ou x(preço - 5-6%)

Console.WriteLine(@$"
Que tipo de combustível você gostaria de utilizar no seu veículo?

G                                      A

Gasolina                               Álcool
Preço: R$5,30 p/litro                  Preço:R$ 4,90

Desconto de 4% p/litro                 Desconto de 3% p/litro
Acima de 20L: desconto de 6%           Acima de 20L: desconto de 5% 
");

bool lista = false;

while (lista == false) {
    char produto = char.Parse(Console.ReadLine()!.ToUpper());

    switch (produto) {
        case 'G':
        Console.WriteLine($"Produto escolhido: GASOLINA");
        Console.WriteLine($"Quantos litros de gasolina?");
        float litroGas = Litros();

        if (litroGas <= 20) {
            Console.WriteLine(@$"
Valor a ser pago:
R$ {Math.Round(Desconto(litroGas, litroGas, 100, 4), 2)}
");
        } else {
            Console.WriteLine(@$"
Valor a ser pago: 
R$ {Math.Round(Desconto(litroGas, litroGas, 100, 6), 2)}
");            
        }
        lista = true;
        break;

        case 'A':
        Console.WriteLine($"Produto escolhido: ÁLCOOL");
        Console.WriteLine($"Quantos litros de álcool?");
        float litroAlc = Litros();

        if (litroAlc <= 20) {
            Console.WriteLine(@$"
Valor a ser pago:
R$ {Math.Round(Desconto(litroAlc, litroAlc, 100, 3), 2)}
");
        } else {
            Console.WriteLine(@$"
Valor a ser pago:
R$ {Math.Round(Desconto(litroAlc, litroAlc, 100, 5), 2)}
");
        }
        lista = true;
        break;
    }
}




static float Litros() {
    return float.Parse(Console.ReadLine()!);
}

static float Desconto(float n1, float n2, int n3, int n4) {
    return n1 - ((n2 / n3) * n4);
}