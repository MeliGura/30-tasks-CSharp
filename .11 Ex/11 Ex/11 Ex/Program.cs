using System;

class Program
{
    static int[] RemoveNegatives(int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }

        int[] result = new int[count];

        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }

    static void Main()
    {
        int[] array = { 3, -1, 5, -2, 7 };

        int[] newArray = RemoveNegatives(array);

        Console.WriteLine("Результат:");
        PrintArray(newArray);

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
        int[] test = { -5, -2, 0, 4 };

        int[] result = RemoveNegatives(test);

        Console.WriteLine("Тест:");
        PrintArray(result); 
    }
}