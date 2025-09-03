// See https://aka.ms/new-console-template for more information
int num1;
int num2;
int num3;

Console.WriteLine("Digite o valor para A é: ");
num1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Digite o valor para B é: ");
num2 = int.Parse(Console.ReadLine());
num3 = num1;
num1 = num2;
num2 = num3;   
Console.WriteLine($"O valor de A é {num1} e o valor de B é {num2}");

