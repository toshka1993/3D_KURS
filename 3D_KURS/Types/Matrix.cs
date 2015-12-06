using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Matrix
    {
        readonly float[,] matrix;
        readonly int rows;
        readonly int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new float[rows, columns];
        }

        // Индексатор для установки/получения элементов внутреннего массива
        public float this[int i, int j]
        {
            set { matrix[i, j] = value; }
            get { return matrix[i, j]; }
        }

        // Возвращает число строк в матрице
        public int Rows
        {
            get { return rows; }
        }

        // Возвращает число столбцов в матрице
        public int Columns
        {
            get { return columns; }
        }

        // Подпрограмма перемножения матриц
        public static Matrix Multiply(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Rows, B.Columns);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < B.Columns; j++)
                {
                    float tmp = C[i, j];
                    for (int k = 0; k < B.Rows; k++)
                    {
                        tmp += A[i, k] * B[k, j];
                    }
                    C[i, j] = tmp;
                }
            }
            return C;
        }
    }
}
