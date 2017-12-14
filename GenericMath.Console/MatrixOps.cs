using System;

namespace GenericMath.Console
{
    class MatrixOps<T>
    {
        public virtual void Add(T[,] first, T[,] second, T[,] result)
        {
            int n = first.GetLength(0), m = first.GetLength(1);
            if (n != second.GetLength(0) || n != result.GetLength(0)) throw new ArgumentException("Размеры матриц должны совпадать");
            if (m != second.GetLength(1) || m != result.GetLength(1)) throw new ArgumentException("Размеры матриц должны совпадать");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    result[i, j] = MathOperations.Add(first[i, j], second[i, j]);
        }
    }

    class MatrixOpsInt : MatrixOps<int>
    {
        public sealed override void Add(int[,] first, int[,] second, int[,] result)
        {
            int n = first.GetLength(0), m = first.GetLength(1);
            if (n != second.GetLength(0) || n != result.GetLength(0)) throw new ArgumentException("Размеры матриц должны совпадать");
            if (m != second.GetLength(1) || m != result.GetLength(1)) throw new ArgumentException("Размеры матриц должны совпадать");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    result[i, j] = first[i, j] + second[i, j];
        }
    }
}
