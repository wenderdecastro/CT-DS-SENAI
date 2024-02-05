string nome = "";
int idade = 0;
float salario = 0f;
char estadoCivil = ' ';



do{

Console.WriteLine($"Insira seu nome: ");

nome = Console.ReadLine();

} while(nome == "");

do{

Console.WriteLine($"Insira sua idade: ");

idade = int.Parse(Console.ReadLine());


} while(idade < 0 || idade > 100);
do{

Console.WriteLine($"Insira o seu salário: ");

salario = float.Parse(Console.ReadLine());

} while(salario < 0);

do{

Console.WriteLine($"Insira seu estado civil: ('s' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a) e 'd' para divorciado(a))");

estadoCivil = char.Parse(Console.ReadLine().ToLower());

} while(estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd' );

Console.WriteLine($"Informações validadas!");
