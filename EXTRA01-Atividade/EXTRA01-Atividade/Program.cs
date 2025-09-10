// See https://aka.ms/new-console-template for more information
double dinheiro;
double dolar; 
Console.WriteLine("Digite quantos reais você tem na carteira!");
dinheiro = Double.Parse(Console.ReadLine());

dolar = dinheiro / 3.45;

Console.WriteLine($"Você pode comprar {dolar} dolares, com {dinheiro} reais que você tem");


