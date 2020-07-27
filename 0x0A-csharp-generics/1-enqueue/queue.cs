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

	/// <summary> Return number of nodes in queue </summary>
	public int Count()
	{
		return count;
	}

	/// <summary> Node class </summary>
	public class Node
	{
		dynamic value = null;
		public Node next = null;

		public Node(dynamic newValue)
		{
			value = newValue;
		}
	}

}
