//Console.WriteLine("1. Contagem de 1 a 10");
//Console.WriteLine("Crie um programa que exiba os números de 1 a 20 na tela.");
//Console.WriteLine();

//for(int i = 1; i <= 20; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine();

//Console.WriteLine("2. Validação de senha");
//Console.WriteLine("Peça ao usuário para inserir a senha \"1234\". Continue pedindo até que ele acerte.");
//Console.WriteLine();

//int senha;
//do
//{
//    Console.WriteLine("Digite a senha");
//    senha = int.Parse(Console.ReadLine());
//} while (senha != 1234);
//Console.WriteLine();

//Console.WriteLine("3. Tabuada de um número");
//Console.WriteLine("Peça ao usuário um número e exiba a tabuada dele de 1 a 10");
//Console.WriteLine();

//Console.WriteLine("Escolha um numero para exibir sua tabuada:");
//int numero = int.Parse(Console.ReadLine());
//Console.WriteLine();

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} * {i} é igual a : {numero * i}");
//}

//Console.WriteLine();


Console.WriteLine("5. Média de notas");
Console.WriteLine("Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.");
Console.WriteLine();

int nota;
int soma = 0;
int x = 1;
Console.WriteLine("Digite sua primeira nota:");
nota = int.Parse(Console.ReadLine());

if (nota >= 0 && nota <= 10)
{
    soma += nota;
    while (nota >= 0 && nota <= 10)
    {
        Console.WriteLine("Digite sua nota:");
        nota = int.Parse(Console.ReadLine());
        if(nota > 0 && nota < 10)
        {
            soma += nota;
            x++;
        }
    };
    Console.WriteLine("Voce digitou uma nota invalida");
    Console.WriteLine($" Sua média é igual a {soma / x} de acorda com as notas informadas.");
}
else
{
    Console.WriteLine("Nota inválida");
}