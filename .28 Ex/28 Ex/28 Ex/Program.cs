using System;

class Program
{
    static void ShiftRight(int[] arr)
    {
        int last = arr[arr.Length - 1];

        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[0] = last;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4 };

        ShiftRight(array);

        PrintArray(array);
    }
}
