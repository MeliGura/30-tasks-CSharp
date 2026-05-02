using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        string text = "abba";

        bool result = IsPalindrome(text);

        Console.WriteLine("Результат: " + result);

        Test();
    }

    static void Test()
    {
        Console.WriteLine(IsPalindrome("racecar")); 
        Console.WriteLine(IsPalindrome("hello"));  
    }
}