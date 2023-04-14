

static float floated() {
    return float.Parse(Console.ReadLine()!);
}





// criar método para somar dois números

Console.WriteLine($"Calculadora de soma: ");

float x = floated();
float y = floated();

float resultadoSoma = Soma(x, y);

static float Soma(float n1, float n2) {
    return n1 + n2;
}

Console.WriteLine(resultadoSoma);

// criar um método para subtrair dois números

Console.WriteLine($"Calculadora de subtração: ");

float a = floated();
float b = floated();

float resultadoSub = Subtracao(a, b);

static float Subtracao(float n1, float n2) {
    return n1 - n2;
}

Console.WriteLine(resultadoSub);

// criar um método para multiplicar dois números

Console.WriteLine($"Calculadora de multiplicação: ");

float f = floated();
float g = floated();

float resultadoMult = Multiplicacao(f, g);

static float Multiplicacao(float n1, float n2) {
    return n1 * n2;
}

Console.WriteLine(resultadoMult);

// criar um método pata dividir dois números

Console.WriteLine($"Calculadora de divisão: ");

float m = floated();
float n = floated();

float resultadoDiv = Divisao(m, n);

static float Divisao(float n1, float n2) {
    return n1 / n2;
}

Console.WriteLine(resultadoDiv);
