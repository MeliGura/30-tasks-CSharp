using System;

class Program
{
    static double Average(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        double avg = (double)sum / arr.Length;

        return avg;
    }

    static void Main()
    {
        int[] array = { 2, 4, 6, 8 };

        double result = Average(array);

        Console.WriteLine("Среднее значение: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { 1, 2, 3 };

        Console.WriteLine(Average(test)); 
    }
}