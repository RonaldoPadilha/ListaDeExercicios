/* 5. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
Multiplique a nota de cada prova pelo seu respectivo peso, some os resultados e divida pela soma total dos pesos
*/

Console.Clear();
//Coleta de dados
Console.WriteLine("Digite a nota da primeira prova: ");
double notaPrimeiraProva = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da primeira prova: ");
double pesoPrimeiraProva = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a nota da segunda prova: ");
double notaSegundaProva = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da segunda prova: ");
double pesoSegundaProva = Convert.ToDouble(Console.ReadLine());

//Calculo
double primeiraProva = notaPrimeiraProva * pesoPrimeiraProva;
double segundaProva = notaSegundaProva * pesoSegundaProva;

double totalDasProvas = primeiraProva + segundaProva;
double totalDosPesos = pesoPrimeiraProva + pesoSegundaProva;

double mediaPonderada = totalDasProvas / totalDosPesos;

//Saida de dados
Console.WriteLine($"A média ponderada de suas provas é: {mediaPonderada}");

Console.ReadLine();