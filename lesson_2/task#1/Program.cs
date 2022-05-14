using static System.Console;
using static System.Convert;
using static System.Math;

Write("Введите x: ");
var x = ToDouble(ReadLine());
double y = 0;

if (x < 0.1)
{
    y = Sqrt(Abs( (2*Pow(x, 2)) + Sin(x) + 1 ));
}
else if (x == 0.1)
{
    y = (2*x) + Pow(E, x);
}

WriteLine($"y = {y}");