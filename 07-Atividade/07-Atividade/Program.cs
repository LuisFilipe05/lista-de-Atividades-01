// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Digite um valor!");
int num1;

num1 = int.Parse(Console.ReadLine());
if (num1 > 10)
{
    Console.WriteLine("O número digitado é maior que 10!");
}
else
{
    Console.WriteLine("O número digitado é menor que 10!");
}


