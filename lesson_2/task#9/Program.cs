using static System.Console;
using static System.Convert;

Write("Введите первое число: ");
var first_digit = ToInt64(ReadLine());

Write("Введите второе число: ");
var second_digit = ToInt64(ReadLine());

Write("Введите третье число: ");
var third_digit = ToInt64(ReadLine());

if ((first_digit == second_digit) || (second_digit == third_digit) || (second_digit == third_digit) || (first_digit == third_digit))
{
    WriteLine("Есть совпадающая пара");
}
else
{
    WriteLine("Совпадающей пары нет");
}