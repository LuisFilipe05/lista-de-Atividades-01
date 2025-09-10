// See https://aka.ms/new-console-template for more information
int ano1;
int ano2;
int anoVoto;
Console.WriteLine("Digite o ano atual!");
ano1 = int. Parse(Console.ReadLine());

Console.WriteLine("Digite o ano em que você nasceu!");
ano2 = int.Parse(Console.ReadLine());

anoVoto = ano1 - ano2;
if (anoVoto >= 18 )
{
    Console.WriteLine($"Você tem {anoVoto} anos, sendo assim, você é obrigado a votar!");
}
else
{
    Console.WriteLine($"Você tem {anoVoto} anos, sendo assim, você não é obrigado a votar!");
}