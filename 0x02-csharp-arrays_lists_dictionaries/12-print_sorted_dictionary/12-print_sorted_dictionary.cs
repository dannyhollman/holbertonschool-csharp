using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		List<string> list = new List<string>();
		foreach(var pairs in myDict)
			list.Add(pairs.Key + ": " + pairs.Value);
		list.Sort();
		foreach(var x in list)
			Console.WriteLine(x);
	}
}
