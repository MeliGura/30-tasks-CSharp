using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;

            reversed = reversed * 10 + digit;

            number = number / 10;
        }

        return original == reversed;
    }

    static void Main()
    {
        int number = 121;

        bool result = IsPalindrome(number);

        Console.WriteLine(result);
    }
}