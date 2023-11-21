#region For 1
for (int i = 0; i <= 30; i++)
{
    Console.WriteLine(i.ToString());

}
#endregion

#region For 2
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"3 x {i} = {3 * i}");

}
#endregion

#region Do while 1
int numero = 0;

do
{
    Console.WriteLine($"Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero != 0);
#endregion


#region Do while 2
string palavra = "";

do
{
    Console.WriteLine($"Digite uma palavra");
    palavra = Console.ReadLine();

} while (palavra != "parar");

#endregion

#region Foreach 1
List<string> ListaPalavras = new() { "Cavalo", "Garrafa", "Copo", "Espelho", "Mochila" };

foreach (string ListaPalavra in ListaPalavras)
{
    Console.WriteLine(ListaPalavra.ToString());
}
#endregion

#region Foreach 2
List<int> Numeros = new() { 10, 10, 10, 10, 10, 10 };
int resultado = 0;
foreach (int Numero in Numeros)
{
    resultado += Numero;
}
Console.WriteLine(resultado);
#endregion

