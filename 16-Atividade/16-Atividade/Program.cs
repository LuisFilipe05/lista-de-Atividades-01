﻿// See https://aka.ms/new-console-template for more information
int numero;

Console.WriteLine("Digite um numero que irei digitar o fatorial dele (!)");
Console.WriteLine("sabe-se que fatorial negativo não existe");
Console.WriteLine("0! é por definição = 1");
numero = int.Parse(Console.ReadLine());

int fatorial = 1;

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}
Console.WriteLine($"O fatorial de {numero} é {fatorial}");