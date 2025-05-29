using System;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                try
                {
                    Console.WriteLine($"{arg} -> {(IsPalindrome(arg) ? "true" : "false")}");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        public static bool IsPalindrome(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text), "A string não pode ser null");
            if (text.Length < 2) return true;

            text = text.ToLower();
                
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
