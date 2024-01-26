//1) Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.


Console.WriteLine("Qual o dia do seu nascimento?");
int diaAniversario = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o mês do seu nascimento?");
int mesAniversario = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o ano do seu nascimento?");
int anoAniversario = int.Parse(Console.ReadLine());

if(diaAniversario < 1 || diaAniversario > 31)
{
    Console.WriteLine($"O dia de sua data não é válido. Os meses possuem 1 até 31 dias.");

}

if(mesAniversario < 1 || mesAniversario > 12)
{
    Console.WriteLine($"O mês de sua data não é válido. Você inseriu um mês inválido, os meses estão entre 1 e 12!");

}

if(anoAniversario > 2013 || anoAniversario < 1874)
{
    Console.WriteLine($"O ano de sua data não é válido. Se estamos em 2013, não tem como você ter nascido em {anoAniversario}!");

}