using System;
using System.Collections.Generic;

class Array
{
	public static int[] CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		int[] numbers = new int[size];
		for (int i = 0; i < size; i++)
			numbers[i] = i;
		Console.WriteLine(String.Join(" ", numbers));
		return numbers;
	}
}
