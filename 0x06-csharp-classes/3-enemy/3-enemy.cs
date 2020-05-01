using System;

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
