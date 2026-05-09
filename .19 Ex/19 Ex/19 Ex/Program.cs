using System;

class Program
{
    static int SumArray(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4 };

        int result = SumArray(array);

        Console.WriteLine("Сумма массива: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { 5, 5, 5 };

        Console.WriteLine(SumArray(test)); 
    }
}