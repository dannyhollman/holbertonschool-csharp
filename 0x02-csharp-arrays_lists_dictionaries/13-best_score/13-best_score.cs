using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int highest = 0;
		string answer = "";

		foreach(var pairs in myList)
		{
			if (pairs.Value > highest)
			{
				highest = pairs.Value;
				answer = pairs.Key;
			}
		}
		return answer;
	}
}
