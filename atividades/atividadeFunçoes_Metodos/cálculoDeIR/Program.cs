// . Fazer um método para calcular imposto de renda, sendo que:

//renda vs tabela de imposto:

//até $1500          - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000     - 35% de imposto



//algoritmo:

// função para a entrada de dados
// entrada de dados = float
// 4 condições diferentes
// imprimir imposto no final:
// imposto a ser pago = (renda * porcentagem de imposto)

static float Renda() {
    return float.Parse(Console.ReadLine()!);
}




Console.WriteLine($"Insira a sua renda total: ");
Console.WriteLine($"");

float renda = Renda();
