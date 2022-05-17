using static System.Console;
using static System.Convert;
using static System.Math;

class Program
{
    static double F(double x)
    {
        double y = 0;

        if ((Pow(x, 2) + 2*x + 1) < 2)
        {
            y = Pow(x, 2);
        }
        else if ((2 <= (Pow(x, 2) + 2*x + 1)) && ((Pow(x, 2) + 2*x + 1) < 3))
        {
            y = 1 / (Pow(x, 2) - 1);
        }
        else
        {
            y = 0;
        }

        return y;
    }

    static void F(double x, out double y)
    {

        if ((Pow(x, 2) + 2*x + 1) < 2)
        {
            y = Pow(x, 2);
        }
        else if ((2 <= (Pow(x, 2) + 2*x + 1)) && ((Pow(x, 2) + 2*x + 1) < 3))
        {
            y = 1 / (Pow(x, 2) - 1);
        }
        else
        {
            y = 0;
        }
    }

    public static void Main()
    {
        Write("Введите a: ");
        double a = ToDouble(ReadLine());

        Write("Введите b: ");
        double b = ToDouble(ReadLine());

        Write("Введите h: ");
        double h = ToDouble(ReadLine());

        WriteLine($"Первый метод \t Перегруженный метод");

        double y = 0;

        for (double i = a; i <= b; i += h)
        {
            F(i,out y);
            WriteLine($"{Round(i, 2)} = {Round(F(i), 2)} \t {Round(i, 2)} = {Round(y, 2)}");
        }
    }
}