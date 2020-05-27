using System;

class VectorMath
{
	public static double[] Multiply(double[] vector, double scalar)
	{
		double[] error = { -1, -1 };
		if (vector.Length > 3)
			return error;

		for (int i = 0; i < vector.Length; i++)
			vector[i] *= scalar;

		return vector;
	}
}
