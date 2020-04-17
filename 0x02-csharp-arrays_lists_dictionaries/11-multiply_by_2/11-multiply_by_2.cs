using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		Dictionary<string, int> newDict = new Dictionary<string, int>();
		foreach(var pairs in myDict)
			newDict.Add(pairs.Key, pairs.Value * 2);
		return newDict;
	}
}
