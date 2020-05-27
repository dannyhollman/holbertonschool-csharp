using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix1 = { { 2, 3 }, { -1, 0 } };
		double[,] matrix2 = { { 1, 7 }, { -8, -2 } };
		double[,] result = MatrixMath.Multiply(matrix1, matrix2);
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
				Console.Write(result[i, j] + " ");
			Console.WriteLine();
		}
	}
}
