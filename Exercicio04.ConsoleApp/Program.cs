/* 4. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
base e o total de vendas. A comissão é calculada com um percentual (informado pelo
usuário) sobre o total de vendas.
*/
Console.Clear();

Console.WriteLine("Digite o valor do salário base: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor total das vendas: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a porcentagem da comisão: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());

double comissão = totalVendas * porcentagem / 100;

double salarioFinal = salarioBase + comissão;
Console.WriteLine($"O salário total é: R${salarioFinal:F2}");

Console.ReadLine();