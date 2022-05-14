using static System.Console;
using static System.Convert;
using static System.Math;

namespace task_1
{
    class A
    {
        double a;
        double b;

        public double ExpressionEvaluation()
        {
            Write("Введите A: ");
            a = double.Parse(ReadLine());

            Write("Введите B: ");
            b = double.Parse(ReadLine());

            double result = (-b + 1/a) / 3;

            return result;
        }

        public double Cube()
        {
            Write("Введите A: ");
            a = double.Parse(ReadLine());

            Write("Введите B: ");
            b = double.Parse(ReadLine());

            double result = Pow(a+b, 3);

            return result;
        }
    }

    class MainClass 
    {
        public static void Main(string[] args)
        {
            A a = new A();
            WriteLine($"{a.ExpressionEvaluation()}");
            WriteLine($"{a.Cube()}");
        }
    }
}