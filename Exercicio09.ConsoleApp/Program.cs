/* 9. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
    a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    b. Pesquise sobre “fatorial”
*/
//Console.Clear();
Console.WriteLine("---- Fatotial ----");

Console.WriteLine("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());
double resultado = 1;

Console.Write($" {numero}! = ");

for (double contador = numero; contador >= 1; contador--)
{
    resultado = resultado * contador;

    if (contador > 1)
    {
        Console.Write($"{contador} X ");
    }
    else
    {
        Console.Write($"{contador} = {resultado}");
    }
}

Console.ReadLine();