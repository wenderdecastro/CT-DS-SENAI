// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Escreva o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.WriteLine($"Digite a quantidade adquirida");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preço unitário: ");
float preco = float.Parse(Console.ReadLine());

float desconto = 0;

float total = preco * quantidade;

if (quantidade <= 5)
{
    desconto = 0.02f;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = 0.03f;
}
else
{
    desconto = 0.10f;
}

total -= total * desconto;

Console.WriteLine($"O total que o cliente irá pagar em {quantidade} unidades de {nomeProduto} é de {total}");
