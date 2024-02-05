using Calculadora.Objetos;

string operacao = "";
int num1 = 0;
int num2 = 0;
int resultado = 0;
List<string> historico = new();
Calculos calculos = new Calculos();

do
{
    Console.Clear();

    Console.WriteLine("Escolha qual operação matemática deseja realizar:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Historico de operações");
    Console.WriteLine("S - Sair");
    operacao = Console.ReadLine();

    Console.Clear();

    if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao.ToLower() != "s")
    {
        Console.WriteLine("Opção inválida, tente novamente!");
        Console.ReadLine();
        continue;
    }
    else if (operacao.ToLower() == "s")
    {
        break;
    }
    else if (operacao == "5")
    {
        foreach (var item in historico)
        {
            Console.WriteLine($"{item}");
        }
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Insira o primeiro número");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo número");
    num2 = Convert.ToInt32(Console.ReadLine());

    if (operacao == "1")
    {
        resultado = calculos.Somar(num1, num2);
        string auxiliar = $"{num1} + {num2} = {resultado}";

        Console.WriteLine(auxiliar);
        historico.Add(auxiliar);
    }
    else if (operacao == "2")
    {
        resultado = calculos.Subtracao(num1, num2);
        string auxiliar = $"{num1} - {num2} = {resultado}";

        Console.WriteLine(auxiliar);
        historico.Add(auxiliar);
    }
    else if (operacao == "3")
    {
        resultado = calculos.Multiplicacao(num1, num2);
        string auxiliar = $"{num1} * {num2} = {resultado}";

        Console.WriteLine(auxiliar);
        historico.Add(auxiliar);
    }
    else if (operacao == "4")
    {
        if (num2 == 0)
        {
            do
            {
                Console.WriteLine("Não é possível dividir por zero");
                Console.WriteLine("Tente novamente!!");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira o primeiro número");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o segundo número");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num2 == 0);
        }

        resultado = calculos.Divisao(num1, num2);
        string auxiliar = $"{num1} / {num2} = {resultado}";

        Console.WriteLine(auxiliar);
        historico.Add(auxiliar);
    }

    Console.ReadLine();
} while (true);



