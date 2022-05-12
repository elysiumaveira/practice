using static System.Console;
using static System.Convert;

Write("Введите трёхзначное число: ");
var digit = ReadLine();

WriteLine($"{digit[1]}{digit[0]}{digit[2]}");