using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
    static void FindPrimes(int N)
    {
        for (int i = 2; i <= N; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Main()
    {
        int N = 20;

        Console.WriteLine("Простые числа до " + N + ":");
        FindPrimes(N);

        Console.WriteLine();
        Test();
    }

    static void Test()
    {
        Console.WriteLine("Тест до 10:");
        FindPrimes(10);
    }
}