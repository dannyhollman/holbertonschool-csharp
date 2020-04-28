using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> newList = new List<int>();

		foreach(var x in list1)
			if(!list2.Contains(x))
				newList.Add(x);
		foreach(var x in list2)
			if(!list1.Contains(x))
				newList.Add(x);
		newList.Sort();
		return newList;
	}
}
