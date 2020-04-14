using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
			int number = 0;

			for (; number < 100; number++)
				Console.Write((number != 0 ? ", " : "") + "{0:D2}", number);
			Console.WriteLine("");
        }
    }
}
