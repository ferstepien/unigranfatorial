using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro para calcular o fatorial: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
        }
        else
        {
            Console.WriteLine("Digite um número inteiro não negativo.");
        }
    }

    static long CalcularFatorial(int n)
    {
        long resultado = 1;
        Console.Write("Cálculo: ");
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
            Console.Write(i);
            if (i < n)
                Console.Write(" x ");
        }
        Console.WriteLine($" = {resultado}");
        return resultado;
    }
}
