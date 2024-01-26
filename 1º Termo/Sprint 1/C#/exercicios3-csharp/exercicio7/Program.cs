int[] numeros = new int[15];

for (var i = 0; i < 15; i++)
{
    Console.WriteLine("Insira um valor: ");
    numeros[i] = int.Parse(Console.ReadLine());

}
for (var i = 14; i > 0; i--)
{
    Console.WriteLine("Os numeros em ordem inversa são: ");
    Console.WriteLine(numeros[i]);
}


