using System;

class Program
{
    static void Main()
    {
        int rows = 100;
        int cols = 200;

        int[,] matrix = new int[rows, cols];

        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(-3, 11);
            }
        }
        Console.WriteLine("Массив Заполнен рандомными числами от -3 до 10");
    }
}