using static System.Console;
using static System.Convert;
using static System.Math;
using static System.Environment;

double x = 0.0;

Write("Введите x: ");

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
    if ((-1 < x) && (x < 1))
    {
        double f = Cos(x) / x;
        WriteLine($"f({x}) = {f}");
    }
    else if (1 <= x)
    {
        double f = 5*x + 2;
        WriteLine($"f({x}) = {f}");
    }
    else throw new Exception("Ошибка допустимых значений x");
}
catch(DivideByZeroException ex)
{
    WriteLine($"Произошла ошибка {ex}");
    Exit(0);
}