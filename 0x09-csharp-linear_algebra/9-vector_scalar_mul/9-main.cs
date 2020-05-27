using System;

class Program
{
	static void Main(string[] args)
	{
		double[] test1 = { 0, -16, 31 };
		double sca1 = 0.5;
		Console.WriteLine(VectorMath.Multiply(test1, sca1));
		double[] test2 = { 98, 972 };
		double sca2 = 4;
		Console.WriteLine(VectorMath.Multiply(test2, sca2));
	}
}
