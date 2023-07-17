// See https://aka.ms/new-console-template for more information
using System;

class Program
{

    public static int LerNumero()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int LerInteiro(int min, int max)
    {
        int x;

        do
        {
            Console.WriteLine("Insira um número");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < min || x > max)
            {
                Console.WriteLine("O número não é válido");
            }
        }
        while (x < min || x > max);
        return x;

    }

    static void Main(string[] args)
    {

        int minimo, maximo;

        Console.WriteLine("Defina o mínimo");
        minimo = LerNumero();
        Console.WriteLine("Defina o máximo");
        maximo = LerNumero();

        LerInteiro(minimo, maximo);
    }
}
