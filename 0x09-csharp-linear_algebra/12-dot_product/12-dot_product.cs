using System;

class VectorMath
{
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length > 3 || vector2.Length > 3 || vector1.Length != vector2.Length)
			return -1;

		double x, y, z, dot = 0;

		if (vector1.Length == 3)
		{
			x = vector1[0] * vector2[0];
			y = vector1[1] * vector2[1];
			z = vector1[2] * vector2[2];
			dot = x + y + z;
		}

		if (vector2.Length == 2)
		{
			x = vector1[0] * vector2[0]; 
			y = vector2[1] * vector2[1];
			dot = x + y;
		}
		return dot;
	}
}
