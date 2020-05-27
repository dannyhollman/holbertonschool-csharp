using System;

namespace _16_matrix_scalar_mul
{
    class Program
    {
        static void Main(string[] args)
        {
			double[,] matrix = { { -13, 10, 8 }, { 2, 0, 14 }, { -4, -5, 2 } };
			double[,] result = MatrixMath.MultiplyScalar(matrix, 4);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
					Console.Write(matrix[i, j] + " ");
				Console.WriteLine();
			}
        }
    }
}
