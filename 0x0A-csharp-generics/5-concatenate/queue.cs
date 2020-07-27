using System;

/// <summary> test </summary>
class Queue<T>
{
	Node head = null;
	Node tail = null;
	int count = 0;

	/// <summary> Check type of T </summary>
	public Type CheckType()
	{
		return typeof(T);
	}
	/// <summary> Add node to queue </summary>
	public void Enqueue(dynamic val)
	{
		Node newNode = new Node(val);
		if (head == null)
			head = newNode;
		if (tail != null)
			tail.next = newNode;
		tail = newNode;
		count++;
	}
	
	/// <summary> Remove first node and return value </summary>
	public dynamic Dequeue()
	{
		if (head != null)
		{
			dynamic val = head.value;
			head = head.next;
			count--;
			return val;
		}
		Console.WriteLine("Queue is empty");
		return default(T);
	}

	/// <summary> Return value of first node without removing </summary>
	public dynamic Peek()
	{
		if (head != null)
			return head.value;
		Console.WriteLine("Queue is empty");
		return default(T);
	}

	/// <summary> Prints the queue </summary>
	public void Print()
	{
		Node temp = head;
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return;
		}
		while (temp != null)
		{
			Console.WriteLine(temp.value);
			temp = temp.next;
		}
	}

	/// <summary> Concatenates all values in queue </summary>
	public string Concatenate()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}
		else if (typeof(T) == typeof(string) || typeof(T) == typeof(char))
		{
			string result = "";
			Node temp = head;
			while (temp != null)
			{
				result += temp.value;
				if (temp.next != null && typeof(T) == typeof(string))
					result += " ";
				temp = temp.next;
			}
			return result;
		}
		else
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return null;
		}
	}

	/// <summary> Return number of nodes in queue </summary>
	public int Count()
	{
		return count;
	}

	/// <summary> Node class </summary>
	public class Node
	{
		public dynamic value = null;
		public Node next = null;

		public Node(dynamic newValue)
		{
			value = newValue;
		}
	}

}
