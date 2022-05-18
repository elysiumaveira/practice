using static System.Console;
using static System.Convert;
using static System.Math;

void DigitCountSum(string k)
{
    int c = k.Length;
    int s = 0;

    k = ToInt16(k);
    
    while (k > 0)
    {   
        s += k % 10;
        k = k / 10;
    }

    WriteLine($"Количество цифр числа k: {c}");
    WriteLine($"Сумма цифр числа k: {s}");
}

Write("Введите K: ");
string k = ReadLine();

DigitCountSum(k);