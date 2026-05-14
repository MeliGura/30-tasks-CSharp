using System;

class Program
{
    static int[] RemoveDuplicates(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool exists = false;

            for (int j = 0; j < count; j++)
            {
                if (arr[i] == temp[j])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                temp[count] = arr[i];
                count++;
            }
        }

        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }

        return result;
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
        int[] array = { 1, 2, 2, 3, 1, 4 };

        int[] result = RemoveDuplicates(array);

        PrintArray(result);
    }
}