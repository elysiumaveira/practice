using System;
using static System.Math;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Factorial(int x)
        { 
            double result = Atan(x);
            Console.WriteLine($"Значение функции Arctg(x) при x={x} будет равно {Math.Round(result, 3)}");
        }

        static void Main(string[] args)
        {
            int a = -10;

            int b = 1;

            Parallel.For(a, b, Factorial);
        }
    }
}
