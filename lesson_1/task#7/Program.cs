using static System.Console;
using static System.Convert;

double Perimeter(double a, double b)
{
    var result = 2 * a + 2 * b;

    return result;
}

double Length(double a, double b)
{
    var result = Math.Sqrt(a * a + b *b);

    return Math.Round(result, 2);
}

Write("Введите a: ");
double a = ToDouble(ReadLine());

Write("Введите b: ");
double b = ToDouble(ReadLine());

WriteLine($"Периметр: {Perimeter(a, b)}");
WriteLine($"Длина диагонали: {Length(a, b)}");