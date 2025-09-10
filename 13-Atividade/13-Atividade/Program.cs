// See https://aka.ms/new-console-template for more information
int num1, num2, num3;
Console.WriteLine("Digite o primeiro valor, sabendo que ele não pode ser igual o segundo e nem ao terceiro valor!");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor, sabendo que ele não pode ser igual o primeiro e nem ao terceiro valor!");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor, sabendo que ele não pode ser igual o primeiro e nem ao segundo valor!");
num3 = int.Parse(Console.ReadLine());


if (num1 >= num2)
{
    Console.WriteLine($"O primeiro valor é maior que o segundo e o terceiro valor!");
}
else if (num2 >= num3)
{
    Console.WriteLine($"O segundo valor é maior que o primeiro e o terceiro valor!");
}
else
{
    Console.WriteLine($"O terceiro valor é maior que o primeiro e o segundo valor!");
}

