/*
    2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
        O programa deve solicitar ao usuário:
            a. A quilometragem inicial do veículo no início da viagem.
            b. A quilometragem final ao término da viagem.
            c. A quantidade de combustível consumida durante a viagem (em litros).
    .Divida o total de litros abastecidos pela distância percorrida
    .(Fórmula): Consumo = Distância percorrida / Quantidade de combustivel
    .(Fórmula): C = DP / QC
*/
Console.Clear();

Console.WriteLine("Digite o Km inicial: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o Km final: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustivel gasta no percurso (em litros): ");
double combustivel = Convert.ToDouble(Console.ReadLine());

double distância = kmFinal - kmInicial;
double consumo = distância / combustivel;

Console.WriteLine($"O consumo de combistível da viagem é de: {consumo} Km/l .");

Console.ReadLine();