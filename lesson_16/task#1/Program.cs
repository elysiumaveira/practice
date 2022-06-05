using System;
using static System.Console;

namespace task1
{
    class MyList<T>
    {
        protected int index = 0;
        protected T[] Values = new T[0];
        
        public void Add(T value)
        {
            Array.Resize(ref Values, index+1);

            Values[index] = value;
            index++;
        }
        public T this[int index]
        {
            get => Values[index];
        }
        
        public int Length
        {
            get => Values.Length ; 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList <int> list = new MyList<int>();
            list.Add(3213123);
            list.Add(219389);
            list.Add(92849);
            WriteLine($"Элемент с индексом 1: {list[1]}");
            WriteLine($"Длина: {list.Length}");
        }
    }
}