using System;
using System.Collections.Generic;
using System.Linq;

class List
{
	public static List<int> DeleteAt(List<int> myList, int index)
	{
		if (index >= myList.Count)
		{
			Console.WriteLine("Index out of range");
			return myList;
		}
		myList.Remove(myList[index]);
		return myList;
	}
}
