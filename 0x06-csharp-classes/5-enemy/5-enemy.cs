using System;

namespace Enemies
{
	/// <summary>
	/// Zombie class
	/// </summary>
    public class Zombie
    {
		public int health;
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

		/// <summary>
		/// ToString override
		/// </summary>
		public override string ToString()
		{
			return String.Format("Zombie name: {0} / Total Health: {1}", name, health); 
		}
    }
}
