using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 0;

			for (; i < 100; i++)
			{
				if ((i / 10) < (i % 10))
				{
					Console.Write("{0:D2}", i);
					if (i != 89)
						Console.Write(", ");
				}
			}
			Console.WriteLine("");
        }
    }
}
