// . Crie uma Classe de um Celular, com as propriedades cor,
// modelo, tamanho, ligado(booleano) com os métodos, ligar, 
// desligar, fazer ligação, enviar mensagem.
// . Só será possível executar tais métodos se o celular estiver
// ligado.


// algoritmo

// Classe: Celular, nome de instância: phone
// Métodos: Ligar, Desligar, Discar, Enviar mensagem e Sair
// Se Celular estiver desligado: Funcionar apenas Ligar e Sair
// . Ligar/Desligar: Ações para o bool local;
// . Enviar mensagem/Discar: Strings locais;
// . Sair encerra o programa
// . Ligado ou não: bool Local

using celularPOO;

Celular phone = new Celular();

bool reset = false;




Console.WriteLine(@$"
Acesso ao Celular
{phone.nome}
{phone.cor}
{phone.modelo}
{phone.tamanho}");

phone.ligado = false;
bool status = false;
do
{
    switch (phone.ligado)
    {
        case false:
            Console.WriteLine(@$"
        Desligado
        
        [1] Ligar
        [0] Sair
        ");


            do
            {
                string comando = Console.ReadLine()!;

                switch (comando)
                {
                    case "1":
                        phone.Ligar();
                        status = true;
                        break;

                    case "0":
                        status = true;
                        reset = true;
                        break;

                    default:
                        Console.WriteLine($"Caractér invalido");
                        break;
                }
            } while (status == false);
            break;

        case true:
            Console.WriteLine($"Ligado");

            Console.WriteLine($"");
            Console.WriteLine($"");

            do
            {
                Console.WriteLine(@$"
        [0] Sair
        [1] Enviar mensagem
        [2] Discar
        [3] Desligar");

                string acao = Console.ReadLine()!;

                switch (acao)
                {
                    case "1":
                        Console.WriteLine($"Escreva sua mensagem: ");
                        Console.ReadLine();
                        phone.Mensagem();
                        break;

                    case "2":
                        Console.WriteLine($"Digite o número de celular");
                        Console.ReadLine();
                        phone.Discar();
                        break;

                    case "3":
                        phone.Desligar();
                        break;

                    case "0":
                        phone.ligado = false;
                        reset = true;
                        break;

                    default:
                        Console.WriteLine($"Caractér inválido");

                        break;
                }

            } while (phone.ligado == true);
            break;
    }

} while (reset == false);