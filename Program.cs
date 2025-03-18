Console.WriteLine("1. Contagem de 1 a 10");
Console.WriteLine("Crie um programa que exiba os números de 1 a 20 na tela.");
Console.WriteLine();

for(int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("2. Validação de senha");
Console.WriteLine("Peça ao usuário para inserir a senha \"1234\". Continue pedindo até que ele acerte.");
Console.WriteLine();

int senha;
do
{
    Console.WriteLine("Digite a senha");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);
Console.WriteLine();

Console.WriteLine("3. Tabuada de um número");
Console.WriteLine("Peça ao usuário um número e exiba a tabuada dele de 1 a 10");
Console.WriteLine();

Console.WriteLine("Escolha um numero para exibir sua tabuada:");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine();

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} é igual a : {numero * i}");
}