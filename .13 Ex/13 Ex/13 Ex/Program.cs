using System;

class Program
{
    static bool Contains(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int[] array = { 3, 7, 2, 9 };

        bool result = Contains(array, 7);

        Console.WriteLine("Найдено: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { 1, 2, 3 };

        Console.WriteLine(Contains(test, 2)); 
        Console.WriteLine(Contains(test, 5)); 
    }
}