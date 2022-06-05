using static System.Console;
using static System.Convert;

Write("Введите количество секунд: ");
var seconds = ToInt64(ReadLine());
double hours = 0;

hours = (seconds / 60) / 60;

WriteLine($"Часов прошло: {hours}");