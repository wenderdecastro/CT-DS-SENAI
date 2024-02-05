Console.WriteLine($"Quantas maçãs você deseja comprar?");
int quantidade = int.Parse(Console.ReadLine());
float precoMacas = 0.30f;
float total = precoMacas * quantidade;

if (quantidade < 12)
{
    Console.WriteLine($"Você está comprando {quantidade} maçãs, que totaliza {string.Format("{0:C2}", total)}.");
}
else
{
    precoMacas = 0.25f;
    Console.WriteLine($"Você está comprando {quantidade} maçãs, que totaliza {string.Format("{0:C2}", total)}, por comprar 12 ou mais unidades, você recebeu 0.05R$ de desconto por unidade!");
}