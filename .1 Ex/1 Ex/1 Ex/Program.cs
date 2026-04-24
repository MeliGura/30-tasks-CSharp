using System;

class Program
{
    static void Main()
    {
        int rows = 100; 
        int cols = 200;

        float[,] matrix = new float[rows, cols];
        Random rand = new Random();
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i,j] = (float)(rand.NextDouble()*2 - 1);
            }
        }   
        Console.WriteLine("Массив Заполнен");
    }
}