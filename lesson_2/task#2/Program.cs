using static System.Console;
using static System.Convert;

Write("Введите четырехзначное число: ");
var number = ReadLine();

int first_digit = ToInt16(number[0]);
int second_digit = ToInt16(number[1]);

if (first_digit > second_digit)
{
    WriteLine($"Первая цифра числа {number} больше");
}
else
{
    WriteLine($"Вторая цифра числа {number} больше");
}