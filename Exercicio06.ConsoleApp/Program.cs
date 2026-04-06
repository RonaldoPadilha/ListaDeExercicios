/* 6. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
*/
Console.Clear();
//Coleta de dados
Console.WriteLine("Digite o valor de A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
double B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
double C = Convert.ToDouble(Console.ReadLine());

double soma = A + B; 
//Condição
if (soma < C)
{
    Console.WriteLine("A soma de A + B é menor que C ");
}
else if (soma == C)
{
    Console.WriteLine("A soma de A + B é igual a C ");
}
else
{
    Console.WriteLine("A soma de A + B é maior que C ");
}

Console.ReadLine();