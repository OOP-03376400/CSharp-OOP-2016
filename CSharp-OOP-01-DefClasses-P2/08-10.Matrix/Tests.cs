namespace _08_10.Matrix
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(5, 5);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            Console.WriteLine(matrix);
        }
    }
}
