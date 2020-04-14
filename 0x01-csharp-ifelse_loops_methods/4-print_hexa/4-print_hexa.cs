using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
			int number = 0;

			for (; number < 99; number++)
				Console.WriteLine("{0} = 0x{0:x}", number);
        }
    }
}
