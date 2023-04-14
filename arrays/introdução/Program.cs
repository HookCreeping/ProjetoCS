// // // SEM ARRAY

// string fruta1;
// string fruta2;
// string fruta3;

// Console.WriteLine($"Fale uma fruta: ");
// fruta1 = Console.ReadLine()!;

// Console.WriteLine($"Diga outra fruta: ");
// fruta2 = Console.ReadLine()!;

// Console.WriteLine($"Diga mais outra fruta: ");
// fruta3 = Console.ReadLine()!;

// Console.WriteLine($"{fruta1}, {fruta2}, {fruta3}");



// // // COM ARRAY

// string[] frutas = new string[3];

// Console.WriteLine($"Fale uma fruta: ");
// frutas[0] = Console.ReadLine()!;

// Console.WriteLine($"Diga outra fruta: ");
// frutas[1] = Console.ReadLine()!;

// Console.WriteLine($"Diga mais outra fruta: ");
// frutas[2] = Console.ReadLine()!;

// Console.WriteLine($"{frutas[0]}, {frutas[1]}, {frutas[2]}");

// // // COM ARRAY E FOR

// string[] frutas = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Fale uma fruta:");
//     frutas[i] = Console.ReadLine()!;
// }

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Fruta: {frutas[i]}");
// }

// // COM ARRAY E FOREACH

string[] frutas = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Fale uma fruta: ");
    frutas[i] = Console.ReadLine()!;
}

foreach (var item in frutas)
{
 Console.WriteLine($"Fruta: {frutas}");
}