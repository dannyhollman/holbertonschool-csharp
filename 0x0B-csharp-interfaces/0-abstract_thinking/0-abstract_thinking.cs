using System;

/// <summary> Base class </summary>
public abstract class Base
{
	/// <summary> name </summary>
	public string name;
	/// <summary> Override ToString </summary>
	public override string ToString()
	{
		return name + " is a " + this.GetType();
	}
}
