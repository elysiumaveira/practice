using static System.Console;
using static System.Convert;

Write("Введите число: ");
var number = ReadLine();

for (int i = 0; i < number.Length; i++)
{
    if (i % 2 != 0)
    {
        Write(number[i]);
    }
}