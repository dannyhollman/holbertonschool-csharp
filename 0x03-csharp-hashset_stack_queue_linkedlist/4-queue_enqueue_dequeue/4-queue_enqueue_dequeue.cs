using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		int onoff = 0;
		Console.WriteLine("Number of items: " + aQueue.Count);
		Console.WriteLine("Top item: " + aQueue.Peek());
		Console.WriteLine("Stack contains " + "\"" + search + "\": " + aQueue.Contains(search));
		if(aQueue.Contains(search))
		{
			foreach(string x in aQueue.ToArray())
			{
				if(onoff == 1)
					break;
				aQueue.Dequeue();
				if(x == search)
					onoff = 1;
			}
		}
		aQueue.Enqueue(newItem);
		return aQueue;
	}
}
