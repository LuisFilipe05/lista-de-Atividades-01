// See https://aka.ms/new-console-template for more information
int salario;
float reajuste;

Console.WriteLine("Digite o seu salário ");
salario = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o reajuste que quer fazer no salário");
reajuste = float.Parse(Console.ReadLine());
Console.WriteLine($"Seu novo salário de acordo com o reajuste é de {(reajuste / 100 * salario) + salario}");


