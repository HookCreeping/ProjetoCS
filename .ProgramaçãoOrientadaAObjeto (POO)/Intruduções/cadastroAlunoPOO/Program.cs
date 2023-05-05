// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor
// da Mensalidade. 

// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos
//  o cálculo da mensalidade.

// obs:
// . bolsista e média final maior ou igual a 8 conceder 50% de 
// desconto na mensalidade
// . bolsista e média final maior que 6 e menor que 8 conceder 30%
//  de desconto na mensalidade 
// outros casos a mensalidade será integral
// . Receba os dados do cadastro via console e crie um menu para o
// usuário escolher se quer visualizar a média ou o valor da mensalidade.






// algoritmo:
// NOME, CURSO, IDADE, RG == string;
// BOLSISTA == bool;
// VALOR MENSALIDADE, MÉDIA FINAL == float 

using cadastroAlunoPOO;
CadastroAluno aluno = new CadastroAluno();

bool reset;
string bolsista;


Console.WriteLine($"Nome: ");
aluno.nome = Rl();
string nome = aluno.nome;
Br();

Console.WriteLine($"Idade: ");
aluno.idade = Rl();
string idade = aluno.idade;
Br();

Console.WriteLine($"RG: ");
aluno.rg = Rl();
string rg = aluno.rg;
Br();

reset = false;
do
{
    Console.WriteLine($"É bolsista? S/N");
    bolsista = Console.ReadLine()!.ToLower();

    switch (bolsista)
    {
        case "s":
            aluno.bolsa = true;
            reset = true;
            break;

        case "n":
            aluno.bolsa = false;
            reset = true;
            break;

        default:
            Console.WriteLine($"Caractér inválido");
            break;
    }

} while (reset == false);
reset = false;
Br();

Console.WriteLine($"Média final: ");
aluno.media = float.Parse(Rl());
float media = aluno.media;
Br();

Console.WriteLine($"Mensalidade: ");
aluno.mensal = float.Parse(Rl());

aluno.Mensalidade();

Console.WriteLine(@$"

---------------------------------------------------------------|
  Nome: {nome}        RG: {rg}

  Idade: {idade}      

  Bolsista: {bolsista.ToUpper()}             Média: {media}

  Total da Mensalidade: R${aluno.calcMedia}
---------------------------------------------------------------|
 ");









// shortCodes
static string Br()
{
    Console.WriteLine($"");
    return "";
}

static string Rl()
{
    return Console.ReadLine()!;
}