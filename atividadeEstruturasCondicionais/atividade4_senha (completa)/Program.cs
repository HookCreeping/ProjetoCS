// Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. 
// A senha válida é o número 1234. 
// Devem ser impressas as seguintes mensagens:
// ACESSO PERMITIDO caso a senha seja válida.
// ACESSO NEGADO caso a senha seja inválida.

// Se a senha for 2444 (um 2 três 4), o acesso serã permitido. Senão, o acesso será negado.

Console.WriteLine($"Insira a senha: ");
int InputSenha = int.Parse(Console.ReadLine()!);

int senha = 2444;

if (senha == InputSenha) {
    Console.WriteLine($"ACESSO PERMITIDO");

} else {
    Console.WriteLine($"ACESSO NEGADO");
    
}