using System;

/// <summary> VectorMath class </summary>
class VectorMath
{
	/// <summary> Multiply two vectors </summary>
	public static double[] Multiply(double[] vector, double scalar)
	{
		double[] error = { -1, -1 };
		if (vector.Length != 3 && vector.Length != 2)
			return error;

		for (int i = 0; i < vector.Length; i++)
			vector[i] *= scalar;

		return vector;
	}
}
