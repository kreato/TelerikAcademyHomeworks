
namespace DefiningClassesPart2
{
    using System;
    using System.Text;
    public class Matrix<T> where T : IComparable<T>
    {
        private readonly T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows,cols];
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0)!= m2.matrix.GetLength(0) || m1.matrix.GetLength(1)!= m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }

            return result;
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) || m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(1) != m2.matrix.GetLength(0))
            {
                throw new ArgumentException("Matrices cannot be multiplyed");
            }
            Matrix<T> resultMatrix = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));
            T result = (dynamic)0;
            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m2.matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < m1.matrix.GetLength(1); k++)
                    {
                        result += (dynamic)m1[i, k] * m2[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }
            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    result.Append(string.Format("{0, 5}", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}