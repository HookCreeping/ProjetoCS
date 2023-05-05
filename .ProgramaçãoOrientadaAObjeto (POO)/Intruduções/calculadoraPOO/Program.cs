// Criar uma calculadora usando POO 

// . Classe: Calculadora;
// . Atributos: Inserir números e operações;
// . Métodos: (x _ y), onde "x" é número, "y" é outro número e
//  "_" é operação (+ , - , * e /)

// Arrays para números;
// Switch Case para as operações


using calculadoraPOO;
Calculadora matemática = new Calculadora();

bool loop = false;

do
{
    Console.WriteLine(@$"
   C A L C U L A D O R A
    
                     
    7     8     9    *
    
    4     5     6    - 
    
    1     2     3    +

    Exit        0    /
");

    Console.WriteLine($"Insert x");
    matemática.x = float.Parse(Console.ReadLine()!);
    Console.WriteLine($"");


    Console.WriteLine($"Insert operator");
    bool error = false;
    do
    {
        matemática.digito = Console.ReadLine()!;

        if ((matemática.digito == "+") || (matemática.digito == "-") || (matemática.digito == "*") || (matemática.digito == "/"))
        {
            error = true;
        }
        else
        {
            Console.WriteLine($"Invalid Character");
        }

    } while (error == false);
    Console.WriteLine($"");
    

    Console.WriteLine($"Insert y");
    matemática.y = float.Parse(Console.ReadLine()!);


    Console.WriteLine($"");
    Console.WriteLine(matemática.Operacao(matemática.digito, matemática.x, matemática.y));


    Console.WriteLine($"");
    Console.WriteLine($"End of operation");

    string restart = Console.ReadLine()!.ToLower();
    if (restart == "exit")
    {
        loop = true;
    }
} while (loop == false);