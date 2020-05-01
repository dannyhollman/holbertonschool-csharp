﻿using System;

namespace Enemies
{
	/// <summary>
	/// Zombie class
	/// </summary>
    public class Zombie
    {
		/// <summary>
		/// Zombie health
		/// </summary>
		public int health;

		/// <summary>
		/// Zombie name
		/// </summary>
		private string name = "(No name)";

		/// <summary>
		/// Getter and setter for name
		/// </summary>
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		/// <summary>
		/// Zombie constructor
		/// </summary>
		public Zombie()
		{
			health = 0;
		}	

		/// <summary>
		/// Zombie constructor with health value
		/// </summary>
		public Zombie(int value)
		{
			if(value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}

		/// <summary>
		/// Returns health
		/// </summary>
		public int GetHealth()
		{
			return health;
		}
    }
}
