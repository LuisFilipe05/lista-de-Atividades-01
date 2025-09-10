// See https://aka.ms/new-console-template for more information
int num1, num2, num3;
Console.WriteLine("Digite o primeiro valor, sabendo que ele não pode ser igual o segundo e nem ao terceiro valor!");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor, sabendo que ele não pode ser igual o primeiro e nem ao terceiro valor!");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor, sabendo que ele não pode ser igual o primeiro e nem ao segundo valor!");
num3 = int.Parse(Console.ReadLine());

int menor, meio, maior;
if (num1 <= num2 && num1 <= num3)
{
    menor = num1;
    if (num2 <= num3)
    {
        meio = num2;
        maior = num3;
    }
    else
    {
        meio = num3;
        maior = num2;
    }
}
else if (num2 <= num1 && num2 <= num3)
{
    menor = num2;
    if (num1 <= num3)
    {
        meio = num1;
        maior = num3;
    }
    else
    {
        meio = num3;
        maior = num1;
    }
}
else
{
    menor = num3;                             
    if (num1 <= num2)
    {
        meio = num1;
        maior = num2;
    }
    else
    {
        meio = num2;
        maior = num1;
    }
}

Console.WriteLine($"Ordem crescente: {menor}, {meio}, {maior}");