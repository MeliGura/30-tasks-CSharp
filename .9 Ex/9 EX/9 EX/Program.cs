using System;

class Program
{
    static int CountEven(int[] arr)
    {
        int count = 0; 

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 6 };

        int result = CountEven(array);

        Console.WriteLine("Количество чётных: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { 7, 9, 11 };

        Console.WriteLine("Тест: " + CountEven(test));  
    }
}