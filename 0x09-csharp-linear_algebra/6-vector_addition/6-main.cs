using System;

class Program
{
	static void Main(string[] args)
	{
		double[] vector1 = { 14, -2, 0 };
		double[] vector2 = { -3, 23, 50 };
		double[] result = VectorMath.Add(vector1, vector2);
		Console.WriteLine("(" + String.Join(", ", result) + ")");


		double[] vector3 = { 14, -2 };
		double[] vector4 = { -3, 23 };
		result = VectorMath.Add(vector3, vector4);
		Console.WriteLine("(" + String.Join(", ", result) + ")");

	}
}
