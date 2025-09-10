// See https://aka.ms/new-console-template for more information
int anoAtual  = 2025;
int anoNascimento;
int anoVoto;
Console.WriteLine("Digite o ano atual!");
anoAtual = int. Parse(Console.ReadLine());

Console.WriteLine("Digite o ano em que você nasceu!");
anoNascimento = int.Parse(Console.ReadLine());

anoVoto = anoAtual - anoNascimento;
if (anoVoto >= 18)
{
    Console.WriteLine($"Você tem {anoVoto} anos, sendo assim, você é obrigado a votar!");
}
else if (anoVoto <= 16)
{
    Console.WriteLine($"Você tem {anoVoto} anos, sendo assim, você não é obrigado a votar!");
}
else
{
    Console.WriteLine($"Você tem {anoVoto} anos, sendo assim, seu voto é facultativo!");
}