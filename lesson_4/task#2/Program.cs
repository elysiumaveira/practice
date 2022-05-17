using static System.Console;
using static System.Convert;
using static System.Math;

static double F(double x)
{
    double y = 0;

    if ((Pow(x, 2) + 2*x + 1) < 2)
    {
        y = Pow(x, 2);
    }
    else if ((2 <= (Pow(x, 2) + 2*x + 1)) && ((Pow(x, 2) + 2*x + 1) < 3))
    {
        y = 1 / (Pow(x, 2) - 1);
    }
    else
    {
        y = 0;
    }

    return y;
}

Write("Введите a: ");
double a = ToDouble(ReadLine());

Write("Введите b: ");
double b = ToDouble(ReadLine());

Write("Введите h: ");
double h = ToDouble(ReadLine());

for (double i = a; i <= b; i += h)
{
    WriteLine($"{Round(i, 2)} = {Round(F(i), 2)}");
}