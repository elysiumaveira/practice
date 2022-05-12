using static System.Console;
using static System.Convert;

double x = 6.4;

var y = (Math.Pow(2.8, x) / Math.Cos(Math.Sqrt(x-1))) + (2*Math.Atan(Math.Pow(x, 2)) / (1 - x));

WriteLine(Math.Round(y, 2));