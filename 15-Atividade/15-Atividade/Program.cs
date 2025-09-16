// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("Irei conferir os numeros de 1000 a 2000 e também os quando dividido por 11, tem resto igual a 5");
int contador;
for (contador = 1000; contador <= 2000; contador++)
{
    if (contador % 11 == 5)
    {
        Console.WriteLine($"{contador}");
    }
}