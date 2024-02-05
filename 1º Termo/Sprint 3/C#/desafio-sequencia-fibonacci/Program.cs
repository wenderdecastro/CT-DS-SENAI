int numero1 = 1;
int numero2 = 0;
int numeroTotal = 0;
while(numeroTotal < 500)
{
    numeroTotal = numero1 + numero2;
    Console.WriteLine(numeroTotal);
    numero1 = numero2;
    numero2 = numeroTotal;
}
