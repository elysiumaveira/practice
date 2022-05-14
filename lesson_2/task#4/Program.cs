using static System.Console;
using static System.Convert;

WriteLine("Дюймы \t Сантиметры");

for (int i = 2; i <= 24; i += 2)
{
    WriteLine($"{i} \t {ToDouble(i * 2.54)}");
}