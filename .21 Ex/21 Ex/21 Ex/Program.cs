using System;

class Program
{
    static void SwapMinMax(int[] arr)
    {
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }

            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
        }

        int temp = arr[minIndex];
        arr[minIndex] = arr[maxIndex];
        arr[maxIndex] = temp;
    }

    static void Main()
    {
        int[] array = { 5, 2, 8, 1, 4 };

        Console.WriteLine("До:");
        PrintArray(array);

        SwapMinMax(array);

        Console.WriteLine("После:");
        PrintArray(array);

        Test();
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    static void Test()
    {
        int[] test = { 10, 3, 7 };

        SwapMinMax(test);

        Console.WriteLine("Тест:");
        PrintArray(test);
    }
}