using System;

class Program
{
    static double VectorLength(double[] vector)
    {
        double sum = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sum += vector[i] * vector[i];
        }
        return Math.Sqrt(sum);
    }

    static void Test()
    {
        Console.WriteLine("=== Запуск тестов ===");

        double[] v1 = { 3, 4 };
        double len1 = VectorLength(v1);
        Console.WriteLine($"Вектор (3, 4): длина = {len1} (ожидается 5)");

        double[] v2 = { 0, 0, 0 };
        double len2 = VectorLength(v2);
        Console.WriteLine($"Вектор (0, 0, 0): длина = {len2} (ожидается 0)");

        double[] v3 = { 1, 1, 1, 1 };
        double len3 = VectorLength(v3);
        Console.WriteLine($"Вектор (1, 1, 1, 1): длина = {len3} (ожидается 2)");

        double[] v4 = { -2, -2 };
        double len4 = VectorLength(v4);
        Console.WriteLine($"Вектор (-2, -2): длина = {len4} (ожидается ~2.828)");

        Console.WriteLine("=== Тесты завершены ===\n");
    }

    static void Main()
    {
        Test();  

        Console.WriteLine("Введите размерность вектора (n):");
        int n = int.Parse(Console.ReadLine());

        double[] vector = new double[n];
        Console.WriteLine($"Введите {n} координат(у/ы) вектора (через Enter):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"x[{i + 1}] = ");
            vector[i] = double.Parse(Console.ReadLine());
        }

        double length = VectorLength(vector);
        Console.WriteLine($"\nДлина вектора = {length:F4}");
    }
}