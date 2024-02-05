Console.WriteLine("Qual o raio da circunferência? Insira os centimetros em valores inteiros.");
double raio = double.Parse(Console.ReadLine());

Console.WriteLine($"O diâmetro do é igual à: {2 * raio}cm, o comprimento da circunferência é igual à: {(2 * Math.PI) * raio}cm, e a área da circunferência é igual à: {(Math.Pow(raio, 2)) * Math.PI}cm.");
