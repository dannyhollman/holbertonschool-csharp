using System;
using System.Linq;

namespace Text
{
    /// <summary> Str class </summary>
    public class Str
    {
        /// <summary> Checks if string is a palindrome </summary>
        public static bool IsPalindrome(string s)
        {
            string temp = s.ToLower();
            temp = String.Concat(temp.Where(char.IsLetter));
            char[] array = temp.ToCharArray();
            Array.Reverse(array);
            string newString = new string(array);
            if (temp == newString)
                return true;
            return false;
        }
    }
}