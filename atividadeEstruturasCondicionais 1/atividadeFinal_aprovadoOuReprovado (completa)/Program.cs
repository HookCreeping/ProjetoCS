// Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência
// maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência
// mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. 
// Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? 
// Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, 
// porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, 
// em recuperação ou reprovado.

// Para aluno ser aprovado, média = 7 e frequência = 75%. 
// Se frequência < 75%, aluno reprovado. 
// Se média < 7, aluno reprovado.

Console.WriteLine($"Digite o nome do/a aluno/a. ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Digite a média do/a aluno/a. ");
float media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a frequência (em porcentagem) do/a aluno/a. ");
int frequencia = int.Parse(Console.ReadLine()!);


if ((media >= 7) && (frequencia >= 75)) {
    Console.WriteLine($"Aluno/a {nome} APROVADO/A.");
    
} else if ((media >= 3) && (frequencia >= 75)) {
    Console.WriteLine($"Aluno/a {nome} encaminhado/a para RECUPERAÇÃO.");
    
} else {
    Console.WriteLine($"Aluno/a {nome} REPROVADO/A.");
    
}