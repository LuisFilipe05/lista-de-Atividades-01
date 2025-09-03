// See https://aka.ms/new-console-template for more information
int idadeEmMeses;
int idadeEmDias;
int idadeEmAnos;
int totalIdade;

Console.WriteLine("Digite quantos dias se passaram do seu aniversário");
idadeEmDias = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantos meses se passaram do seu anivesário");
idadeEmMeses = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantos anos você tem");
idadeEmAnos = int.Parse(Console.ReadLine());
totalIdade = (idadeEmMeses * 30) + (idadeEmAnos * 365) + idadeEmDias;
Console.WriteLine($"Você tem {idadeEmAnos} anos, {idadeEmMeses} meses e {idadeEmDias} dias");
Console.WriteLine($"Você tem {totalIdade} dias");