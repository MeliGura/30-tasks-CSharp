using System;

class Program
{
    static bool AreEqual(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string first = "hello";
        string second = "hello";

        bool result = AreEqual(first, second);

        Console.WriteLine(result);
    }
}