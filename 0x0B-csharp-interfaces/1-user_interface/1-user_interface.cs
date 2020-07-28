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
/// <summary> TestObject inherits from all interfaces </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary> Tracks durability </summary>
	public int durability {get; set;}
	/// <summary> Tracks if collected </summary>
	public bool isCollected {get; set;}
	/// <summary> Interact function </summary>
	public void Interact() {}
	/// <summary> Break function </summary>
	public void Break() {}
	/// <summary> Collect function </summary>
	public void Collect() {}
}
