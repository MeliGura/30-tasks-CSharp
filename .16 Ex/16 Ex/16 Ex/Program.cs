using System;

class Program
{
    static int CountVowels(string text)
    {
        int count = 0;

        string vowels = "aeiouAEIOU";

        for (int i = 0; i < text.Length; i++)
        {
            if (vowels.Contains(text[i]))
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        string word = "Hello World";

        int result = CountVowels(word);

        Console.WriteLine("Количество гласных: " + result);

        Test();
    }

    static void Test()
    {
        Console.WriteLine(CountVowels("cat")); 
        Console.WriteLine(CountVowels("sky")); 
    }
}