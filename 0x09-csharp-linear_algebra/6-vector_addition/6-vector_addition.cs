using System;

class VectorMath
{
	public static double[] Add(double[] vector1, double[] vector2)
	{
		double[] error = { -1, -1 };
		if (vector1.Length > 3 || vector2.Length > 3 || vector1.Length != vector2.Length)
			return error;

		for (int i = 0; i < vector1.Length; i++)
			vector1[i] += vector2[i];
		return vector1;
	}
}
