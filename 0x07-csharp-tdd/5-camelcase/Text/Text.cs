using System;

namespace Text
{
    /// <summary> Str class </summary>
    public class Str
    {
        /// <summary> Returns number of words in camel case string </summary>
        public static int CamelCase(string s)
        {
            int count = 1;

            if (s == null || s.Length == 0)
                return 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    count += 1;
            }

            return count;
        }
    }
}
