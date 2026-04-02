// 1. Crie um programa para calcular o volume de uma caixa retangular
// multiplico o comprimento, a largura e a altura
// (Fórmula: V = C . L . A)

Console.Clear();
Console.WriteLine("Gigite o comprimento da caixa retangular: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Gigite a largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Gigite a altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é: {volume:F2} cm³");

Console.ReadLine();