using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] array = { 5, 2, 8, 1 };

        Console.WriteLine("До:");
        PrintArray(array);

        BubbleSort(array);

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
        int[] test = { 3, 1, 2 };

        BubbleSort(test);

        Console.WriteLine("Тест:");
        PrintArray(test);
    }
}