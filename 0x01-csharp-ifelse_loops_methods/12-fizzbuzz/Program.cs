using System;

class Program
{
	static void Main(string[] args)
	{
		int number = 1;

		for (; number <= 100; number++)
		{
			if (number % 3 == 0 && number % 5 == 0)
				Console.Write("FizzBuzz");
			else if (number % 3 == 0)
				Console.Write("Fizz");
			else if (number % 5 == 0)
				Console.Write("Buzz");
			else
				Console.Write(number);

			if (number != 100)
				Console.Write(" ");
		}
		Console.WriteLine("");
	}
}
