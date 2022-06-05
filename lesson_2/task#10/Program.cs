using static System.Console;
using static System.Convert;

Write("Введите A: ");
var a = int.Parse(ReadLine());

Write("Введите B: ");
var b = int.Parse(ReadLine());

double result = 0;

for (int i = a; i <= b; i++)
{
    result += i;
}

WriteLine($"Сумма чисел от {a} до {b} = {result}");