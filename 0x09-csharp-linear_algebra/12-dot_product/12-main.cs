using System;

class Program
{
	static void Main(string[] args)
	{
		double[] vector1 = { -4, 0, 10 };
		double[] vector2 = { 3, 7, -9 };
		Console.WriteLine(VectorMath.DotProduct(vector1, vector2));
	}
}
