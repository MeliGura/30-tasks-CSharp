using System;

class Program
{
    static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4 };

        bool result = IsSorted(array);

        Console.WriteLine("Массив отсортирован: " + result);

        Test();
    }

    static void Test()
    {
        int[] test1 = { 1, 2, 3 };
        int[] test2 = { 5, 2, 7 };

        Console.WriteLine(IsSorted(test1)); 
        Console.WriteLine(IsSorted(test2)); 
    }
}