using System;

class Program
{
    static void Main()
    {
        // Эпсилон
        double eps = 1.0;
        double prevEps = eps;

        while (1.0 + eps != 1.0)
        {
            prevEps = eps;
            eps = eps / 2.0;
        }

        Console.WriteLine("Машинный эпсилон: " + prevEps);


        // Ноль
        double x = 1.0;
        double prevX = x;

        while (x != 0.0)
        {
            prevX = x;
            x = x / 2.0;
        }

        Console.WriteLine("Машинный ноль: " + prevX);
    }
}