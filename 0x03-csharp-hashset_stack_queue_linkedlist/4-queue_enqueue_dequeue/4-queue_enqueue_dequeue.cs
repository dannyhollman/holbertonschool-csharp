using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		int onoff = 0;
		Console.WriteLine("Number of items: " + aQueue.Count);
		if(aQueue.Count == 0)
			Console.WriteLine("Queue is empty");
		else
			Console.WriteLine("First item: " + aQueue.Peek());
		Console.WriteLine("Queue contains " + "\"" + search + "\": " + aQueue.Contains(search));
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
