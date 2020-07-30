using System;

/// <summary> Player class </summary>
public class Player
{
	/// <summary> Player name </summary>
	private string name;
	/// <summary> Player max health </summary>
	private float maxHp;
	/// <summary> Player health </summary>
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
		Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
	}
	/// <summary> CalculateHealth delegate </summary>
	public delegate void CalculateHealth(float amount);
	/// <summary> TakeDamage function </summary>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;
		ValidateHP(this.hp - damage);
		Console.WriteLine(this.name + " takes " + damage + " damage!");
	}
	/// <summary> HealDamage function </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		ValidateHP(this.hp + heal);
		Console.WriteLine(this.name + " heals " + heal + " HP!");
	}
	/// <summary> Validate players health </summary>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			this.hp = 0;
		else if (newHp > this.maxHp)
			this.hp = this.maxHp;
		else
			this.hp = newHp;
	}
	/// <summary> Apply modifier </summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
			return baseValue / 2;
		else if (modifier == Modifier.Strong)
			return baseValue * 1.5f;
		else
			return baseValue;
	}
}
/// <summary> enum of modifiers </summary>
public enum Modifier
{
	/// <summary> Weak modifier </summary>
	Weak,
	/// <summary> Base modifier </summary>
	Base,
	/// <summary> Strong modigier </summary>
	Strong
}
/// <summary> Modifier delegate </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
