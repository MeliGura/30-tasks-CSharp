using System;

class Program
{
    static int FindMinIndex(int[] arr)
    {
        int min = arr[0];
        int minIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    static void Main()
    {
        int[] array = { 5, 2, 8, 1, 4 };

        int index = FindMinIndex(array);

        Console.WriteLine("Индекс минимума: " + index);

        Test();
    }

    static void Test()
    {
        int[] test = { 10, 3, 7 };

        Console.WriteLine("Тест: " + FindMinIndex(test)); 
    }
}