using static System.Console;
using static System.Convert;

Write("Введите первое число: ");
var firstDigit = ToDouble(ReadLine());

Write("Введите второе число: ");
var secondDigit = ToDouble(ReadLine());

Write("Введите третье число: ");
var thirdDigit = ToDouble(ReadLine());

WriteLine($"({Math.Round(firstDigit, 2)} + {Math.Round(secondDigit, 2)}) + {Math.Round(thirdDigit, 2)} = {Math.Round(firstDigit, 2)} + ({Math.Round(secondDigit, 2)} + {Math.Round(thirdDigit, 2)})");