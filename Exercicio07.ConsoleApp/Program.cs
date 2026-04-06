/*7. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar
uma indicação sobre a condição de peso de uma pessoa adulta. 
A fórmula é IMC = peso / (altura) 2.
    Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição
    de acordo com a listagem abaixo:
        IMC em adultos Condição
        a. Abaixo de 18,5 - Abaixo do peso
        b. Entre 18,5 e 24,9 - Peso normal
        c. Entre 25 e 29,9 - Acima do peso
        d. Acima de 30 - Obeso
*/
//Console.Clear();
Console.WriteLine("---------- Calculadora do IMC ----------");
Console.WriteLine();

Console.WriteLine("Digite seu peso em Kg: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura usando vírgula(,): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é: {imc:F1}");
    Console.WriteLine("Você está abaixo do peso! ");
}
else if (imc >= 18.5 && imc < 24.9)
{
    Console.WriteLine($"Seu IMC é: {imc:F1}");
    Console.WriteLine("Você está no peso normal! ");
}
else if (imc >= 25 && imc < 29.9)
{
    Console.WriteLine($"Seu IMC é: {imc:F1}");
    Console.WriteLine("Você está Acima do peso! ");
}
else if (imc >= 30)
{
    Console.WriteLine($"Seu IMC é: {imc:F1}");
    Console.WriteLine("Você está obeso! ");
}

Console.ReadLine();