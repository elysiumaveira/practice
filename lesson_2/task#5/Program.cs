using static System.Console;
using static System.Convert;

Write("Введите N: ");
var n = ToInt16(ReadLine());

Write("Введите K: ");
var k = ToInt16(ReadLine());

for (int i = 0; i < n; i++)
{
    WriteLine(k);
}