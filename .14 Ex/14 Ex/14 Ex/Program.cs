using System;

class Program
{
    static string FindLongestWord(string text)
    {
        string[] words = text.Split(' '); 

        string longest = words[0]; 

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }

        return longest;
    }

    static void Main()
    {
        string text = "я люблю программирование";

        string result = FindLongestWord(text);

        Console.WriteLine("Самое длинное слово: " + result);

        Test();
    }

    static void Test()
    {
        string test = "код это сила";

        Console.WriteLine("Тест: " + FindLongestWord(test)); 
    }
}