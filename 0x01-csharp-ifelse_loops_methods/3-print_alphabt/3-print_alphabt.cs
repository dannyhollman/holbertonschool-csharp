using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
			char letter = 'a';

			for (; letter <= 'z'; letter++)
				if (letter != 'q' && letter != 'e')
					Console.Write(letter);
        }
    }
}
