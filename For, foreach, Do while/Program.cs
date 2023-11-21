#region foreach
List<int> numeros = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
foreach (var item in numeros)
{
    Console.WriteLine(item);
}
#endregion

#region for
int limite = 0;

Console.WriteLine($"Digite um limite");
limite = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= limite; i++)
{
    Console.WriteLine(i);
}
#endregion

#region do while
int numero = 0;
do
{
    Console.WriteLine($"Escreva um número");
    numero = Convert.ToInt32(Console.ReadLine());

} while (numero != 0);
#endregion

#region tarefa maior que, menor e igual
List<int> numeros2 = new() { 4, 15, 7, 10, 50 };
foreach (var item in numeros2)
{
    if (item > 10)
    {
        Console.WriteLine($"{item} é maior que 10.");

    }
    else if (item < 10)
    {

        Console.WriteLine($"{item} é menor que 10.");
    }
    else if (item == 10)
    {
        Console.WriteLine($"{item} é igual a 10.");

    }
}
#endregion

#region tarefa maior palavra
List<string> palavras = new() { "Computadoraaaaa", "Desenvolvedor", "Paralelepipedo", "Casa", "Monitor" };
string maiorPalavra = "";
foreach (var palavra in palavras)
{
    if (palavra.Length > maiorPalavra.Length)
    {
        maiorPalavra = palavra;
    }
}
Console.WriteLine($" A maior palavra é: {maiorPalavra}");
#endregion

#region tarefa par e impar
List<int> nums = new() { 10, 21, 24, 27, 50 };
foreach (var item in nums)
{
    if (item % 2 == 0 && item > 20)
    {
        Console.WriteLine($"{item} é par e é maior que 20.");
    }

}
#endregion

#region tarefa pizzaria

Console.WriteLine($"RESPONDA COM SIM OU NAO");
Console.WriteLine($"Você está com fome?");
string respostaFome = Console.ReadLine();

Console.WriteLine($"Você tem dinheiro?");
string respostaDinheiro = Console.ReadLine();

if (respostaFome.ToLower() == "sim" && respostaDinheiro.ToLower() == "sim") ;
{
    Console.WriteLine($"Você deveria ir à Veneza comer uma Pizza");

}
#endregion
