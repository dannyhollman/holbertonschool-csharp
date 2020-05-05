using System;

namespace MyMath
{
    /// <summary> Matrix class </summary>
    public class Matrix
    {
        /// <summary> Divide all elements by num and returns new list </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    newMatrix[i, j] = matrix[i,j] / num;
            
            return newMatrix;
        }
    }
}
