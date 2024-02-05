Console.WriteLine("Digite uma letra: ");
char letra = char.Parse(Console.ReadLine().ToLower());

if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
    Console.WriteLine($"A letra digitada é uma vogal!");

}
else
{
    Console.WriteLine($"A letra digitada é uma consolante.");
    
}
