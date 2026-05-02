using System;

class Program
{
    static int FindMax(int[] arr)
    {
        int max = arr[0]; 

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    static void Main()
    {
        int[] array = { 3, 7, 2, 9, 5 };

        int result = FindMax(array);

        Console.WriteLine("Максимум: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { -1, -5, -3 };

        Console.WriteLine("Тест: " + FindMax(test)); 
    }
}