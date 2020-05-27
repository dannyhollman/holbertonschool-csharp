using System;

class VectorMath
{
	public static double Magnitude(double[] vector)
	{
		double length = 0;
		foreach(double x in vector)
			length += Math.Pow(x, 2);
		return Math.Round(Math.Sqrt(length), 2);
	}
}
