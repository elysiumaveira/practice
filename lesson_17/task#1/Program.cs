using System;
using System.IO;
using static System.Console;
using static System.Convert;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string file = "g.txt";
            File.WriteAllText(file, "");

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText(file, Convert.ToString(random.Next(100)) + " ");
            }

            string readFile = File.ReadAllText(file);
            WriteLine($"Числа в файле: {readFile}");
            string[] numbers = readFile.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(ToInt16(numbers[i]) % 2 == 0)
                {
                    result += 1;
                }
            }

            WriteLine($"Количество четных чисел в файле: {result}");
        }
    }
}