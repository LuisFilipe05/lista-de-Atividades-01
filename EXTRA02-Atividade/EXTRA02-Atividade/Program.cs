// See https://aka.ms/new-console-template for more information
double altura, largura, area;

Console.WriteLine("Digite a altura da parede");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a largura da parede");
largura = double.Parse(Console.ReadLine());

area = largura * altura;
Console.WriteLine($"A quantidade de tinta necessária para pintar a parede é {area / 2} litros");
