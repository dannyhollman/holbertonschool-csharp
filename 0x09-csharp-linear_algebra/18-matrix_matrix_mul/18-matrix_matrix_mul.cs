using System;

/// <summary> MatrixMath class </summary>
class MatrixMath
{
	/// <summary> Multiply two matrices </summary>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
			return new double[,] { { -1 } };

		double[,] matrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

		for (int i = 0; i < matrix1.GetLength(0); i++)
		{
			for (int j = 0; j < matrix2.GetLength(1); j++)
			{
				double temp = 0;
				for (int k = 0; k < matrix1.GetLength(1); k++)
					temp += matrix1[i, k] * matrix2[k, j];
				matrix[i, j] = temp;
			}
		}

		return matrix;
	}
}
