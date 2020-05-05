using System;

namespace Text
{
    /// <summary> Str class </summary>
    public class Str
    {
        /// <summary> Returns index of first non-repeating char </summary>
        public static int UniqueChar(string s)
        {
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] != s[i - 1] && s[i] == s[i + 1])
                    return i - 1;
                else if (s[i] == s[i - 1] && s[i] != s[i + 1])
                    return i + 1;
            }

            return -1;
        }
    }
}
