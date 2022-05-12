using static System.Console;
using static System.Convert;

Console.Write("Введите число: ");

Int64 digit = Int64.Parse(Console.ReadLine());

Int64 reverseDigit = Int64.Parse(new string(digit.ToString().Reverse().ToArray()));

Console.Write($"Обратная запись числа: {reverseDigit}");
