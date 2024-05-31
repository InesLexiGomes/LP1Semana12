using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg} -> {IsPalindrome(arg)}");
            }
        }

        static bool IsPalindrome(string s)
        {
            bool PalindromeChecker()
            {
                // Ignores Capitalization
                s = s.ToLower();
                // Convert to array to be reversed
                char[] chars = s.ToCharArray();


                // Create new string to be reversed
                string newString = "";

                // For each character put it before the new string
                foreach (char c in chars)
                {
                    newString = $"{c}{newString}";
                }

                // if the string equals the string reversed equals true
                if (newString == s) return true;
                else return false;
            }

            // if there's nothing throw an exception
            if (s == "") throw new ArgumentNullException("Empty String");
            
            // if it's just one character it's always a Palindrome
            else if (s.Length < 2) return true;

            else
            {
                return PalindromeChecker();
            }

        }
    }
}
