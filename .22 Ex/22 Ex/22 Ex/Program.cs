using System;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string word1 = "listen";
        string word2 = "silent";

        bool result = IsAnagram(word1, word2);

        Console.WriteLine("Анаграмма: " + result);

        Test();
    }

    static void Test()
    {
        Console.WriteLine(IsAnagram("cat", "act")); 
        Console.WriteLine(IsAnagram("cat", "dog")); 
    }
}