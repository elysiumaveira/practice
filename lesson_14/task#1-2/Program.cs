using static System.Console;

namespace task1_2
{
    class Program
    {
        public delegate void Functions();

        static void Sum()
        {
            WriteLine(4 + 5);
        }
        static void Mult()
        {
            WriteLine(4 * 5);
        }
        static void Div()
        {
            WriteLine(4 / 5);
        }

        static void CallDelegate(Functions functions)
        {
            functions();
        }
        static void Main(string[] args)
        {
            Functions functions = new Functions(Sum);
            functions += Mult;
            functions += Div;
            CallDelegate(functions);
        }
    }
}