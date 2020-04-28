using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		int total = 0;
		HashSet<int> unique = new HashSet<int>();
		foreach(int i in myList)
			unique.Add(i);
		foreach(int i in unique)
			total += i;
		return total;
	}
}
