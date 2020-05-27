using System;

/// <summary> VectorMath class </summary>
class VectorMath
{
	/// <summary> Calculates magnitude of vector </summary>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length > 3 || vector.Length < 2)
			return -1;
		double length = 0;
		foreach(double x in vector)
			length += Math.Pow(x, 2);
		return Math.Round(Math.Sqrt(length), 2);
	}
}
