// See https://aka.ms/new-console-template for more information
double salario;

Console.WriteLine("Digite o salário para ter o aumento de 15%");
salario = double.Parse(Console.ReadLine());

Console.WriteLine($"Seu novo slaário é de {(salario * 1.15) + salario} reais");
