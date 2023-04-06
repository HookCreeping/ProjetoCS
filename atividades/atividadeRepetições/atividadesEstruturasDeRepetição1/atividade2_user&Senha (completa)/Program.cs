// Faça um programa que leia um nome de usuário e a sua senha e não
// aceite a senha igual ao nome do usuário, mostrando uma mensagem de
// erro e voltando a pedir as informações.

// algoritmo:
// se nome == senha, vai dar erro. se nome é diferente, não dará erro.

bool login = false;

while (login == false) {
    Console.WriteLine($"Usuário: ");
    string user = Console.ReadLine()!;

    Console.WriteLine($"Senha: ");
    string senha = Console.ReadLine()!;

    if (user == senha) {
        Console.WriteLine($"Usuário e senha não podem ser os mesmos! Repita novamente!");
    } else {
        login = true;
        Console.WriteLine($"Login realizado com sucessso");
    }
}
