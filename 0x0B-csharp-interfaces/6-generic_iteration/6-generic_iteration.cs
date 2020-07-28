using System;
using System.Collections.Generic;

/// <summary> Base class </summary>
public abstract class Base
{
	/// <summary> name property </summary>
	public string name;
	/// <summary> override ToString </summary>
	public override string ToString()
	{
		return name + " is a " + this.GetType();
	}
}
/// <summary> Interactive interface </summary>
public interface IInteractive
{
	/// <summary> Interact function </summary>
	void Interact();
}
/// <summary> Breakable interface </summary>
public interface IBreakable
{
	/// <summary> tracks durability </summary>
	int durability {get; set;}
	/// <summary> Break function </summary>
	void Break();
}
/// <summary> Colletable interface </summary>
public interface ICollectable
{
	/// <summary> Tracks if collected </summary>
	bool isCollected {get; set;}
	/// <summary> Collect function </summary>
	void Collect();
}
/// <summary> Door class </summary>
public class Door : Base, IInteractive
{
	/// <summary> Door constructor </summary>
	public Door(string name = "Door")
	{
		this.name = name;
	}
	/// <summary> Interact function </summary>
	public void Interact()
	{
		Console.WriteLine("You try to open the " + name + ". It's locked.");
	}
}
/// <summary> Decoration class </summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary> Decoration durability </summary>
	public int durability {get; set;} = 1;
	/// <summary> Decoration isQuestItem </summary>
	public bool isQuestItem = false;
	/// <summary> Decoration constructor </summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability <= 0)
			throw new Exception("Durability must be greater than 0");

		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}
	/// <summary> Interact function </summary>
	public void Interact()
	{
		if (this.durability <= 0)
			Console.WriteLine("The " + this.name + " has been broken.");
		else if (this.isQuestItem)
			Console.WriteLine("You look at the " + this.name + ". There's a key inside");
		else if (!this.isQuestItem)
			Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
	}
	/// <summary> Break function </summary>
	public void Break()
	{
		this.durability--;

		if (this.durability > 0)
			Console.WriteLine("You hit the " + this.name + ". It cracks.");
		else if (this.durability == 0)
			Console.WriteLine("You smash the " + this.name + ". What a mess.");
		else if (this.durability < 0)
			Console.WriteLine("The " + this.name + " is already broken.");
	}
}
/// <summary> Key class </summary>
public class Key : Base, ICollectable
{
	/// <summary> Key isCollected </summary>
	public bool isCollected {get; set;}
	/// <summary> Key constructor </summary>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}
	/// <summary> Collect function </summary>
	public void Collect()
	{
		if (!this.isCollected)
		{
			this.isCollected = true;
			Console.WriteLine("You pick up the " + this.name);
		}
		else
			Console.WriteLine("You have already picked up the " + this.name);
	}
}
/// <summary> Objs class </summary>
public class Objs<T> : List<T>
{
	
}
