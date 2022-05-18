using static System.Console;
using static System.Convert;
using static System.Math;

void DigitCountSum(string k)
{
    int c = k.Length;
    int s = 0;

    int number = ToInt16(k);
    
    while (number > 0)
    {   
        s += number % 10;
        number = number / 10;
    }

    WriteLine($"Количество цифр числа k: {c}");
    WriteLine($"Сумма цифр числа k: {s}");
}

Write("Введите K: ");
string k = ReadLine();

DigitCountSum(k);