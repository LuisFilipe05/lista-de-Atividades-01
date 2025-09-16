// See https://aka.ms/new-console-template for more information
int numero, valor;
Console.WriteLine("Digite um numero e te mostrarei todos os numros inteiros até chegar nele!");
numero = int.Parse(Console.ReadLine());
Console.WriteLine($"Os numeros entre 1 a {numero} são:");

int contador = 1;
while (contador <= numero)
{
    Console.WriteLine($"{contador}");
    contador++;
}

