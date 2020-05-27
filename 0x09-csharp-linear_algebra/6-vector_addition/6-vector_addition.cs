using System;

/// <summary> VectorMath class </summary>
class VectorMath
{
	/// <summary> Add two vectors </summary>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		double[] error = { -1, -1 };
		if (vector1.Length > 3 || vector1.Length < 2)
			return error;
		if (vector2.Length > 3 || vector2.Length < 2)
			return error;
		if (vector1.Length != vector2.Length)
			return error;
		
		double[] sum = new double[vector1.Length];
		for (int i = 0; i < vector1.Length; i++)
			sum[i] = vector1[i] + vector2[i];
		return sum;
	}
}
