using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix1 = { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
		double[,] matrix2 = { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
		double[,] result = MatrixMath.Add(matrix1, matrix2);
		for (int i = 0; i < result.GetLength(0); i++)
		{
			for (int j = 0; j < result.GetLength(1); j++)
				Console.Write(result[i, j] + " ");
			Console.WriteLine("");
		}
	}
}
