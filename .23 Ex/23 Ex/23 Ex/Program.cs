using System;

class Program
{
    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("До:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("После:");
        PrintArray(array);

    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

}
