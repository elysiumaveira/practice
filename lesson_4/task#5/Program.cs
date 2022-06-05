using System;
using System.Collections.Generic;
using System.Linq;
 
class Program
{
    public class Matrix
    {
        double[,] matrix;
        int Row = 0, Col = 0;
        
        //матрица N x M
        public Matrix(int row, int col)
        {
            matrix = new double[row, col];
            Row = row; Col = col;
        }
 
        //квадратная матрица
        public Matrix(int N)
        {
            matrix = new double[N, N];
            Row = Col = N;
        }
 
        //перегрузка индексатора, чтобы обратится к 
        //элементу матрицы как к элементу двумерного массива
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
 
        //перегружаем сложение матриц
        public static Matrix operator + (Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] + second[i, j];
            return mat;
        }
 
        //перегружаем вычитание матриц
        public static Matrix operator - (Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] - second[i, j];
            return mat;
        }
 
        //умножение на число
        public static Matrix operator * (Matrix m, int t)
        {
            Matrix mat = new Matrix(m.Row, m.Col);
            for (int i=0; i<m.Row; i++)
                for (int j = 0; j<m.Col; j++)
                    mat[i,j] = m[i,j] * t;
            return mat;
        }
 
        //распечатать матрицу
        public void PrintMatrix()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }
 
        }
 
        //произведение матриц
        public static Matrix operator * (Matrix first, Matrix second)
        {
            Matrix matr = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
            {
                for (int j = 0; j < second.Col; j++)
                {
                    double sum = 0;
                    for (int r = 0; r < first.Col; r++)
                        sum += first[i, r] * second[r, j];
                    matr[i, j] = sum;
                }
            }
            return matr;
        }
 
        //возведение в степень
        public static Matrix operator ^ (Matrix first, int pow)
        {
            Matrix matr = new Matrix(first.Row, first.Col);
            matr = first;
            for (int z = 1; z < pow; z++)
            {
                Matrix bufer = new Matrix(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Row; j++)
                    {
                        double sum = 0;
                        for (int r = 0; r < first.Row; r++)
                            sum += matr[i, r] * first[r, j];
                        bufer[i, j] = sum;
                    }
                }
                matr = bufer;
            }
            return matr;
        }
    }
 
    static void Main(string[] args)
    {
        //размерность
        int N = 3;
        //степень
        int pow = 3;
 
        Random rand = new Random();
        Matrix first = new Matrix(N);
        Matrix second = new Matrix(N);
 
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
            {
                first[i, j] = rand.Next(1, 4);
                second[i, j] = rand.Next(1, 4);
            }
 
        Console.WriteLine("Первая матрица:");
        first.PrintMatrix();
        Console.WriteLine("\n Вторая матрица:");
        second.PrintMatrix();
        Console.WriteLine("\n Сумма матриц:");
        (first + second).PrintMatrix();
        Console.WriteLine("\n Разница матриц:");
        (first - second).PrintMatrix();
        Console.WriteLine("\n Умножение на число:");
        (first * 3).PrintMatrix();
        Console.WriteLine("\n Произведение матриц:");
        (first * second).PrintMatrix();
        Console.WriteLine($"\n{pow} Степень матрицы:");
        (first ^ pow).PrintMatrix();
    }
}