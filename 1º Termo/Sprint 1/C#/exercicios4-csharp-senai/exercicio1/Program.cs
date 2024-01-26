int nota;
bool valorValido = false;
do{

Console.WriteLine($"Insira de 0 à 10, a nota do aluno: ");
string input = (Console.ReadLine());

if(int.TryParse(input, out nota) && nota <= 10 && nota > 0) {
    valorValido = true;
}


} while(valorValido == false);

Console.WriteLine($"a nota é válida!");
