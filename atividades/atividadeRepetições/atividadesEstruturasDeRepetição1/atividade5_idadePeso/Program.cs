// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas.
// Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.


// algoritmo:

// . 10 pessoas devem fazer a pesquisa
// . peso, idade e sexo são variáveis
// . peso = Float | idade = Int | sexo = Char
// . char sexo deve aumentar a cada pessoa que participar da pesquisa,
// tanto para M (sexo masculino) ou F (sexo feminino)
// . imprimir a quantidade de mulheres e homens no final
// . somar todas as idades de todas as mulheres e dividir pelo número
// delas mesmas. A mesma coisa com os homens.

int homens = 0;
int mulheres = 0;

int somaIdadeMulher = 0;
int somaIdadeHomem = 0;


int total = 0;
for (total = 0; total < 4; total++){
    Console.WriteLine(@$"
    Digite seu sexo:
    F - feminino | M - masculino
    ");
    bool sexo = false;
    while (sexo == false) {
        char genero = char.Parse(Console.ReadLine()!.ToLower());

        switch(genero) {
        case 'f':
        mulheres++;
        
        Console.WriteLine($"Digite sua idade:");
        int idadeF = int.Parse(Console.ReadLine()!);
        somaIdadeMulher = somaIdadeMulher + idadeF;

        Console.WriteLine($"Digite seu peso: ");
        float pesoMulher = float.Parse(Console.ReadLine()!);

        sexo = true;
        total++;
        break;

        case 'm':
        homens++;
        
        Console.WriteLine($"Digite sua idade:");
        int idadeM = int.Parse(Console.ReadLine()!);
        somaIdadeMulher = somaIdadeMulher + idadeM;

        Console.WriteLine($"Digite seu peso: ");
        float pesoHomens = float.Parse(Console.ReadLine()!);

        sexo = true;
        total++;
        break;
        
        default:
        Console.WriteLine($"Inválido");
        break;
        }

}
}
Console.WriteLine($"Homens: {homens} | Mulheres: {mulheres}");
