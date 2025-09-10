// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Digite um valor que não seja 0!");

int num1;
num1 = int.Parse(Console.ReadLine()); 
if (num1 > 0)
{
    Console.WriteLine("O número é positivo!");
}
else
{
    Console.WriteLine("O número é negativo!");
}
