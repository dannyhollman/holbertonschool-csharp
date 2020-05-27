using System;

class MatrixMath
{
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] error = {{ -1 }};
		if (matrix.GetLength(0) > 3 || matrix.GetLength(0) < 1)
			return error;
		if (matrix.GetLength(1) > 3 || matrix.GetLength(1) < 1)
			return error;
		for (int i = 0; i < matrix.GetLength(0); i++)
			for (int j = 0; j < matrix.GetLength(1); j++)
				matrix[i, j] *= scalar;
		return matrix;
	}
}
