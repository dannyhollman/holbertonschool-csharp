using System;

/// <summary> Player class </summary>
public class Player
{
	/// <summary> Player name </summary>
	public string name;
	/// <summary> Player max health </summary>
	public float maxHp;
	/// <summary> Player health </summary>
	public float hp;
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
	/// <summary> CalculateHealth delegate </summary>
	public delegate void CalculateHealth(float amount);
	/// <summary> TakeDamage function </summary>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;
		Console.WriteLine(this.name + " takes " + damage + " damage!");
	}
	/// <summary> HealDamage function </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		Console.WriteLine(this.name + " heals " + heal + " HP!");
	}
}
