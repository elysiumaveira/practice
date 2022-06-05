using static System.Console;

int N = 5;
int M = 5;
int[,] Matrix = new int[N, M];
Random random = new Random();

WriteLine("Матрица из вагонов:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        int rand = random.Next(0, 2);
        Matrix[i, j] = rand;
    }
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Write(Matrix[i, j] + " ");
    }
    WriteLine();
}
for (int i = 0; i < N; i++)
{
    int x = 0;
    {
        for (int j = 0; j < M; j++)
        {
            if (Matrix[i, j] == 0)
            {
                x++;
            }
            else if (x > 0)
            {
                Write("Введите номер вагона: ");
                j = int.Parse(Console.ReadLine());
                WriteLine($" Вагон {j} - Свободных мест в вагоне. {x}");
            }
        }
    }
}