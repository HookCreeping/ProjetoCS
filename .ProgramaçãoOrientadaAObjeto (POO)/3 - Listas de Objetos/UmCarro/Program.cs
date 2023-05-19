// Criar um objeto de console
// Criar uma classe Carro
// Atributos de Carro são: Marca & Cor
// Criar construtor vazio e completo
// Receber dados no console para adicionar 2 objetos em uma lista
// Exibir os dois objetos da lista no console.

using UmCarro;



List<Carro> carList = new List<Carro>();

for (int x = 0; x < 2; x++)
{
    Carro car = new Carro();

    Console.WriteLine($"Marca do carro: ");
    Console.WriteLine($"");

    car.marca = Console.ReadLine()!;
    Console.WriteLine($"");

    Console.WriteLine($"Cor do carro: ");
    car.color = Console.ReadLine()!;
    Console.WriteLine($"");

    carList.Add(car);
    car.id = carList.IndexOf(car);
}



foreach (var info in carList)
{


    Console.WriteLine(@$"
    Número {info.id + 1}                    
                                            
    Nome: {info.marca}                      
    Cor: {info.color}
    ________________________________________
    ");

}