using System;

/// <summary> Player class </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	/// <summary> Player constructor </summary>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp < 0)
		{
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.name = name;
		this.maxHp = maxHp;
		this.hp = maxHp;
	}
	/// <summary> Print current health </summary>
	public void PrintHealth()
	{
		Console.WriteLine(this.name + " had " + this.hp + " / " + this.maxHp + " health.");
	}
}
