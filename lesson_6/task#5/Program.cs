using static System.Console;
using static System.Convert;

int Factorial(int x)
{
    if (x == 1)
    {
        return 1;
    }

    return x * Factorial(x - 1);
}

Write("Введите n: ");
int n = int.Parse(ReadLine());

int f = 1 / (n + 5);

WriteLine($"Факториал f(n) = {f}: {Factorial(f)}");