#region 
//List<int> numeros = new List<int>() { 40, 3, 32, 5, 7, 2, 17, 1, 9, 19, 12, 8 };

//numeros.Sort();

//foreach (int item in numeros)
//{
//    Console.WriteLine(item);

//}

//numeros.Reverse();
//foreach (int item in numeros)
//{
//    Console.WriteLine(item);
//}
#endregion

int os = 0;
int a = 0;
int i = 0;
int der = 0;
int ys = 0;
int an = 0;
List<string> nomes = new List<string>() { "gustavo", "luana", "isadora", "rosane", "rosemeri", "chrystian" };
List<string> palavras = new List<string>() { "os", "a", "i", "der", "ys", "an" };

foreach (string item in nomes)
{
    if (item.Contains("os"))
    {
        os++;
    }

    if (item.Contains("a"))
    {
        a++;
    }

    if (item.Contains("i"))
    {
        i++;
    }

    if (item.Contains("der"))
    {
        der++;
    }

    if (item.Contains("ys"))
    {
        ys++;
    }

    if (item.Contains("an"))
    {
        an++;
    }
}

Console.WriteLine($"E aqui está a contagem: {os}, {a}, {i}, {der}, {ys}, {an}");




