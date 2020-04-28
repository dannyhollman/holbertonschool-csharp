using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int count = 0;

		foreach(var x in myLList)
		{
			if(count == n)
				return x;
			count += 1;
		}
		return 0;
	}
}
