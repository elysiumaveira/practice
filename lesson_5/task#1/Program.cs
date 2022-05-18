using static System.Console;
using static System.Convert;
using static System.Environment;
using static System.Math;

Write("Введите x: ");
double x = 0.0;

try
{
    x = ToDouble(ReadLine());
}
catch(FormatException ex)
{
    WriteLine($"Произошла ошибка {ex}");
    Exit(0);
}

try
{
    double y1 = 1 - (4 / (4*x + 8));
    WriteLine($"a. {y1}");

    double y2 = Tan(x) + (Cos(x) / (3*x + 6));
    WriteLine($"b. {y2}");
}
catch(DivideByZeroException ex)
{
    WriteLine($"Произошла ошибка: {ex}");
    Exit(0);
}