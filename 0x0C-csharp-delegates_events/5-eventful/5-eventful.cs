using System;

/// <summary> Player class </summary>
public class Player
{
	private string status;
	private string name;
	private float maxHp;
	private float hp;
	/// <summary> Event handler </summary>
	public EventHandler<CurrentHPArgs> HPCheck;
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
		this.status = this.name + " is ready to go!";
		this.HPCheck += this.CheckStatus;
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
		Console.WriteLine(this.name + " takes " + damage + " damage!");
		ValidateHP(this.hp - damage);
	}
	/// <summary> HealDamage function </summary>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		Console.WriteLine(this.name + " heals " + heal + " HP!");
		ValidateHP(this.hp + heal);
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
		//this.HPCheck(this, new CurrentHPArgs(this.hp));
		this.OnCheckStatus(new CurrentHPArgs(this.hp));
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
	/// <summary> Check status of player </summary>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
			this.status = this.name + " is in perfect health!";
		else if (e.currentHp >= this.maxHp / 2 && e.currentHp < this.maxHp)
			this.status = this.name + " is doing well!";
		else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
			this.status = this.name + " isn't doing too great...";
		else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4)
			this.status = this.name + " needs help!";
		else
			this.status = this.name + " is knocked out!";
		Console.WriteLine(this.status);
	}
	/// <summary> OnCheckStatus function </summary>
	public void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp < this.maxHp / 4)
			HPCheck += HPValueWarning;
		this.HPCheck(this, e);
	}
	/// <summary> Low health warnings </summary>
	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
			Console.WriteLine("Health has reached zero!");
		else
			Console.WriteLine("Health is low!");
	}

}

/// <summary> enum of modifiers </summary>
public enum Modifier
{
	/// <summary> Weak modifier </summary>
	Weak,
	/// <summary> Base modifier </summary>
	Base,
	/// <summary> Strong moidifier </summary>
	Strong
}

/// <summary> Modifier delegate </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> Current HP args </summary>
public class CurrentHPArgs : EventArgs
{
	/// <summary> Current health </summary>
	public float currentHp;
	/// <summary> Sets current HP </summary>
	public CurrentHPArgs(float currentHp)
	{
		this.currentHp = currentHp;
	}
}
