using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		List<int> array = new List<int>();
		for (int i = 0; i < size; i++)
			array.Add(i);
		Console.WriteLine(String.Join(" ", array));
		return array;
	}
}
