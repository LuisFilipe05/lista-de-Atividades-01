// See https://aka.ms/new-console-template for more information
int eleitores;
int votosBrancos;
int nulos;
int validos;

Console.WriteLine("\nDigite quantos eleitores tem no município");
eleitores = int.Parse(Console.ReadLine());
Console.WriteLine("\nDigite quantos votos brancos teve na eleição");
votosBrancos = int.Parse(Console.ReadLine());
Console.WriteLine("\nDigite quantos votos nulos teve na eleição");
nulos = int.Parse(Console.ReadLine());
Console.WriteLine("\nDigite quantos votos válidos teve na eleição");
validos = int.Parse(Console.ReadLine());

Console.WriteLine($"O percentual de votos brancos em relação ao total de eleitores é de {(votosBrancos * 100)/eleitores}%");
Console.WriteLine($"O percentual de votos nulos em relação ao total de eleitores é de {(nulos * 100) / eleitores}% ");
Console.WriteLine($"O percentual de votos válidos em relação ao total de eleitores é de {(validos* 100) / eleitores}%");