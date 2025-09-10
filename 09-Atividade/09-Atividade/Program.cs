// See https://aka.ms/new-console-template for more information
int maca;
Console.WriteLine("Digite o número de maçãs compradas!");
maca = int.Parse(Console.ReadLine());

if (maca >= 12)
{
    Console.WriteLine($"Você comprou {maca} unidades, o valor é {1.0 * maca} reais");
}
else if (maca <= 11)
{
    Console.WriteLine($"Você comprou {maca} unidades, o valor é {1.3 * maca} reais");
}
