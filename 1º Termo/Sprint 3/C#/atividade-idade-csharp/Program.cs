Console.WriteLine($"Que ano você nasceu?");
int anoAniversario = int.Parse(Console.ReadLine());

int idade = DateTime.Today.Year - anoAniversario;

float idadeSemanas = idade * 52.1786f; 

Console.WriteLine($"Você tem {idade} anos, que corresponde à {Math.Round(idadeSemanas)} semanas");