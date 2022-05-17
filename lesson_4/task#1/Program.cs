using static System.Console;
using static System.Convert;
using static System.Math;

Write("Введите a: ");
var a = ToInt16(ReadLine());

Write("Введите b: ");
var b = ToInt16(ReadLine());

static int F(int x)
{
    int min_digit = 9;

    while (x > 0)
    {
        min_digit = Min(min_digit, x % 10);
        x /= 10;
    }

    return min_digit;
}

int z = F(a) + F(b);

WriteLine($"z = {z}");