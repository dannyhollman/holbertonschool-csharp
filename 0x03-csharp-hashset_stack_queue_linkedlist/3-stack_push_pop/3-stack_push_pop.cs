using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		int onoff = 0;
		Console.WriteLine("Number of items: " + aStack.Count);
		Console.WriteLine("Top item: " + aStack.Peek());
		Console.WriteLine("Stack contains " + "\"" + search + "\": " + aStack.Contains(search));
		if(aStack.Contains(search))
		{
			foreach(string x in aStack.ToArray())
			{
				if(onoff == 1)
					break;
				aStack.Pop();
				if(x == search)
					onoff = 1;
			}
		}
		aStack.Push(newItem);
		return aStack;
	}
}
