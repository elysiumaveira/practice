using static System.Console;
using static System.Math;

double a = 0;
double b = 1;
double m = 20;

double h = (b-a)/m;

WriteLine("x \t Arctg(x)");

for (double x = a; x <= b; x += h)
{
    WriteLine($"{Round(x, 2)} \t {Atan(x)}");
}
