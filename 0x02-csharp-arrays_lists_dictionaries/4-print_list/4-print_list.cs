using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		List<int> array = new List<int>();
		for (int i = 0; i < size; i++)
			array.Add(i);
		Console.WriteLine(String.Join(" ", array));
		return array;
	}
}
