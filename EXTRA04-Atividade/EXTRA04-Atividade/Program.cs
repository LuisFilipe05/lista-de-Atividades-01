// See https://aka.ms/new-console-template for more information
double preco, precoPromocional; 

Console.WriteLine("Digite o preço do produto");
preco = double.Parse(Console.ReadLine());

precoPromocional = preco * 0.05;

Console.WriteLine($"O novo preço do produto é {preco - precoPromocional} reais");
