using System;

class Program
{
    static int SecondMax(int[] arr)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                secondMax = max;
                max = arr[i];
            }
            else if (arr[i] > secondMax && arr[i] != max)
            {
                secondMax = arr[i];
            }
        }

        return secondMax;
    }

    static void Main()
    {
        int[] array = { 5, 8, 2, 10, 7 };

        int result = SecondMax(array);

        Console.WriteLine(result);
    }
}