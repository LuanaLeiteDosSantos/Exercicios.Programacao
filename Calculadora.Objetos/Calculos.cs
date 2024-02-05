namespace Calculadora.Objetos;

public class Calculos
{
    int resultado;
    public int Somar(int Valor1, int Valor2)
    {
        resultado = Valor1 + Valor2;
        return resultado;
    }

    public int Subtracao(int Numero1, int Numero2)
    {
        resultado = Numero1 - Numero2;
        return resultado;
    }

    public int Multiplicacao(int Luana, int Isadora)
    {
        resultado = Luana * Isadora;
        return resultado;
    }

    public int Divisao(int dividendo, int divisor)
    {
        resultado = dividendo / divisor;
        return resultado;
    }
}
