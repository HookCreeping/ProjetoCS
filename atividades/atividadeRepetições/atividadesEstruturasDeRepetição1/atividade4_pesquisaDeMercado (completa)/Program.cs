// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas
// para saber se elas gostaram um determinado produto lançado.
// Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não).
// Faça um programa que calcule e imprima:


// A.O número de pessoas que responderam SIM.

// B.O número de pessoas que responderam NÃO;

// C.O número de mulheres que responderam SIM;

// D.A porcentagem de homens que responderam NÃO entre 
// todos os homens analisados.



// algoritmo:

// -se eu sober a quantidade de mulheres, saberei a quantidade de homens.
// -se eu souber quantas pessoas disseram sim, saberei quantas disseram 
// não
// -porcentagem de homens que disseram não entre todos == 100 / x {%}

Console.WriteLine($"10 pessoas foram entrevistadas");

Console.WriteLine($"Quantas pessoas gostaram do produto?");
bool pesquisa = false;
while (pesquisa == false) {
    int pessoas = int.Parse(Console.ReadLine()!);

    if (pessoas <= 10) {
        pesquisa = true;

        Console.WriteLine($"Quantas pessoas eram mulheres?");
        bool mulheresPesquisa = false;
        while (mulheresPesquisa == false) {
            int mulheres = int.Parse(Console.ReadLine()!);
            
            if (mulheres <= 10) {
                mulheresPesquisa = true;

                Console.WriteLine($"Quantas mulheres gostaram do produto?");
                bool gostosMulheres = false;
                while (gostosMulheres == false) {
                    int mulherGosto = int.Parse(Console.ReadLine()!);

                    if ((mulherGosto <= mulheres) && (mulherGosto <= pessoas)) {
                        gostosMulheres = true;

                        Console.WriteLine(@$"
                        Então:
                        
                        Pessoas entrevistadas: 10;
                        Quantos gostaram: {pessoas};
                        Quantos não gostaram: {10 - pessoas};

                        Mulheres: {mulheres}
                            Gostaram do produto: {mulherGosto}
                            Não gostaram do produto: {mulheres - mulherGosto}
                            Porcentagem de gosto: {mulherGosto * 10}%
                            Porcentagem de desgosto: {(mulheres - mulherGosto) * 10}%

                        Homens: {10 - mulheres}
                            Gostaram do produto: {pessoas - mulherGosto}
                            Não gostaram do produto: {(10 - mulheres) - (pessoas - mulherGosto)}
                            Porcentagem de gosto: {(pessoas - mulherGosto) * 10}%
                            Porcentagem de desgosto: {((10 - mulheres) - (pessoas - mulherGosto)) * 10}%
                        ");
                        
                    } else if (mulherGosto > pessoas) {
                        Console.WriteLine($"Não faz sentido {mulherGosto} mulheres gostarem do produto se apenas {pessoas} pessoas gostaram.");
                        
                    } else {
                        Console.WriteLine($"Há apenas {mulheres} mulheres!");
                    }
                }
            } else {
                Console.WriteLine($"Como há {mulheres} mulheres entre 10 pessoas?");
            }
        }
    } else {
        Console.WriteLine($"Só 10 pessoas foram entrevistadas!");
    }
}
