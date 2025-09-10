// See https://aka.ms/new-console-template for more information
int nota1;
int nota2;
int media;
Console.WriteLine("Digite o valor da sua primeira nota!");
nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da sua segunda nota!");
nota2 = int.Parse(Console.ReadLine());
media = (nota1 + nota2) /2;
if (media >= 6)
{
    Console.WriteLine($"Você foi aprovado com média de {media}");
}
else
{
    Console.WriteLine($"Você foi reprovado com média de {media}");
}