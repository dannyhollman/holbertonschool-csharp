using System;

/// <summary> VectorMath class </summary>
class VectorMath
{
	/// <summary> Find dot product of vectors </summary>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length != 3 && vector1.Length != 2)
			return -1;
		if (vector2.Length != 3 && vector2.Length != 2)
			return -1;
		if (vector1.Length != vector2.Length)
			return -1;

		double dot = 0;

		for (int i = 0; i < vector1.Length; i++)
			dot += vector1[i] * vector2[i];

		return dot;
	}
}
