// 8. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Clear();
Console.WriteLine("---Par ou impar?---");
Console.WriteLine();

Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par! ");
}
else
{
    Console.WriteLine($"O número {numero} é impar! ");
}

Console.ReadLine();