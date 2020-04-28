using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		int count = 0;
		LinkedListNode<int> temp = myLList.First;

		while(temp != null)
		{
			if(count == index)
				myLList.Remove(temp);
			count += 1;
			temp = temp.Next;
		}
	}
}
