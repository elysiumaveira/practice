using static System.Console;
using static System.Convert;

Random rnd = new Random();

Write("Введите n: ");
int n = ToInt16(ReadLine());

Write("Введите a: ");
int a = ToInt16(ReadLine());

Write("Введите b: ");
int b = ToInt16(ReadLine());

double sum_of_even = 0;
int count_of_positive = 0;

double[,] matrix = new double[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = rnd.Next(a, b);
    }
}

WriteLine();
WriteLine($"Матрица {n}x{n}");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"{matrix[i,j]}");
    }
    WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            sum_of_even += matrix[i,j];
        }

        if(matrix[i,j] >= 0)
        {
            count_of_positive += 1;
        }
    }
}

WriteLine($"Сумма четных элеметнов матрицы: {sum_of_even}");
WriteLine($"Количество положительных элементов матрицы: {count_of_positive}");

