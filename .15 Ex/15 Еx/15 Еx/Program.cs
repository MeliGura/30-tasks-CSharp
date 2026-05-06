using System;

class Program
{
    static bool HasDuplicates(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 2 };

        bool result = HasDuplicates(array);

        Console.WriteLine("Есть повторы: " + result);

        Test();
    }

    static void Test()
    {
        int[] test1 = { 1, 2, 3 };
        int[] test2 = { 5, 5, 1 };

        Console.WriteLine(HasDuplicates(test1)); 
        Console.WriteLine(HasDuplicates(test2)); 
    }
}