// O QUE É UMA FUNÇÃO?
// .Função (ou método) parte de um programa/classe que retorna um valor.
// .Para criar um método, basta adicionar "()" na frente das classes.

// Existem métodos Pré-Definidos, como WriteLine()
// Lembrete: camelCase é para variáveis, PascalCase é para métodos

static void NewMethod() {
    Console.WriteLine(@$"
    . Todas as vezes que um método for acionado (invocado),
    independente do que ele tiver dentro, será escrito/passado 
    À máquina, como agora.
    
    ");
}

NewMethod();

OutroMethod();

static void OutroMethod() {
    Console.WriteLine(@$"
    . Não importa a posição do método, se está em cima ou abaixo
    de sua 'descrição', ele funcionará da mesma forma
    
    ");
}


Console.WriteLine(ReturnExemplo());

static string ReturnExemplo() {
    return @"
    . Para escrever, por exemplo, em uma função, podemos
    utilizar  o Console.WriteLine e (se o método for uma string) 
    return (mas para isso, ao invés de 'static void' deve ser colocado
    'static string')
    
    ";
}



//estrutura de uma função:

//tipo tipoDado nomeFuncao(parametros/argumentos) 
{
    //corpo da função
}