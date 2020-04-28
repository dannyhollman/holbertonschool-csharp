using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> temp = myLList.First;

		while(temp != null)
		{
			if(n < temp.Value)
			{
				myLList.AddBefore(temp, n);
				return temp;
			}
			temp = temp.Next;
		}
		myLList.AddLast(n);
		return myLList.Last;
	}
}
