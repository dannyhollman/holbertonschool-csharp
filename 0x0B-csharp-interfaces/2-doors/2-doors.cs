using System;

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
/// <summary> Door class, inherits from Base and Interactive </summary>
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
