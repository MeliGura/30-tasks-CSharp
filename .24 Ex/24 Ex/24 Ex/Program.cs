using System;

class Program
{
    static int CountWords(string text)
    {
        string[] words = text.Split(' ');

        return words.Length;
    }

    static void Main()
    {
        string text = "Я люблю программирование";

        int result = CountWords(text);

        Console.WriteLine(result);
    }
}