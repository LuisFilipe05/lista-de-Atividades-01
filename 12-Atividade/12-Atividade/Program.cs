// See https://aka.ms/new-console-template for more information

int num1, num2;
Console.WriteLine("Digite o primeiro valor, sabendo que ele não pode ser igual o segundo valor!");
num1 = int. Parse( Console.ReadLine() );

Console.WriteLine("Digite o segundo valor, sabendo que ele não pode ser igual o primeiro valor!");
num2 = int. Parse( Console.ReadLine() );       

if ( num1 >= num2 )
{
    Console.WriteLine($"O primeiro valor é maior que o segundo valor!");
}
else
{
    Console.WriteLine($"O segundo valor é maior que o primeiro valor!");
}