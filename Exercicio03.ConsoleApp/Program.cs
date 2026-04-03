// 3. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit.
// Multiplique a temperatura em Celsius por 1,8 e some 32 ao resultado para obter o valor em Fahrenheit.
// (Fórmula): F = C * 1,8 + 32

Console.Clear();
Console.WriteLine("------- Conversor de Celsius para Fahrenheit -------");
Console.WriteLine();
Console.WriteLine("Digite a temperatura em °C");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 1.8 + 32;
Console.WriteLine();
Console.WriteLine("A conversão é: " + fahrenheit + " °F");

Console.ReadLine();