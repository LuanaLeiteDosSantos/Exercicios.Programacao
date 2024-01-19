int respostaUser = 0;
double num = 0;
double resultado = 0;
double resultadoFinal = 0;
do
{
    
    Console.WriteLine("\nQual opção deseja?\n" +
        "1 - Fahrenheit para Celsius\n" +
        "2 - Celsius para Fahrenheit\n" +
        "3 - Km para Milhas\n" +
        "4 - Milhas para Km\n" +
        "5 - Sair");
    
    respostaUser = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if(respostaUser == 5)
    {
        break;
    }

    Console.WriteLine("digite o numero");

    num = Convert.ToDouble(Console.ReadLine());

    if (respostaUser == 1)
    {
        resultado = num - 32;
        resultadoFinal = resultado / 1.8;
        Console.WriteLine(resultadoFinal.ToString("F2"));
        
    }
    else if (respostaUser == 2)
    {
        resultado = num * 1.8;
        resultadoFinal = resultado + 32;
        Console.WriteLine(resultadoFinal.ToString("F2"));
        
    }
    else if (respostaUser == 3)
    {
        resultadoFinal = num * 0.621371;
        Console.WriteLine(resultadoFinal.ToString("F2"));
        
    }
    else if (respostaUser == 4)
    {
        resultadoFinal = num * 1.60934;
        Console.WriteLine(resultadoFinal.ToString("F2"));
        
    }
} while (respostaUser != 5);


