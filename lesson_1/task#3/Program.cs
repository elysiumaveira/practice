using static System.Console;
using static System.Convert;

Write("Введите альфа: ");
var alpha = ToDouble(ReadLine());

var z1 = (Math.Cos(alpha) + Math.Sin(alpha)) / (Math.Cos(alpha) - Math.Sin(alpha));
var z2 = Math.Tan(2*alpha) + (1 / Math.Cos(alpha));

WriteLine($"z1 = {z1}");
WriteLine($"z2 = {z2}");