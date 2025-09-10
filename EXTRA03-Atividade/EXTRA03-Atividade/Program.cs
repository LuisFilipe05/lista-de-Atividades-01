// See https://aka.ms/new-console-template for more information
double a, b, c, delta; 

Console.WriteLine("Digite o valor de A");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de C");
c = double.Parse(Console.ReadLine());

delta = (b * b) - 4 * a * c;

Console.WriteLine($"O valor de delta é {delta}");