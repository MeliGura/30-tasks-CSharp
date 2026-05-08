using System;

class Program
{
    static int MostFrequent(int[] arr)
    {
        int maxCount = 0;
        int mostFrequent = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = arr[i];
            }
        }

        return mostFrequent;
    }

    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 2, 4 };

        int result = MostFrequent(array);

        Console.WriteLine("Самое частое число: " + result);

        Test();
    }

    static void Test()
    {
        int[] test = { 5, 5, 1, 1, 1 };

        Console.WriteLine(MostFrequent(test)); 
    }
}