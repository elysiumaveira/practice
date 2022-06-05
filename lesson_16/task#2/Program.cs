using System;
using static System.Console;


namespace task2
{
    class MyDictionary<TKey,TValue>
    {
        protected int index = 0;
        protected TKey[] Keys = new TKey[0];
        protected TValue[] Values = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(Keys, key) == -1)
            {
                Array.Resize(ref Keys, index + 1);
                Keys[index] = key;

                Array.Resize(ref Values, index + 1);
                Values[index] = value;

                index++;
            }
            else 
            {
                WriteLine("Значение с таким ключем уже существует"); 
            }
        }
        public TValue this[TKey index]
        {
            get => Values[Array.IndexOf(Keys,index)];
        }

        public int Length
        {
            get => Values.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> list = new MyDictionary<string, int>();
            list.Add("smth", 32994);
            list.Add("questions?", 200002);
            list.Add("answers!", 101);
            list.Add("WhoAreYou", 5345353);
            WriteLine("Элемент с ключем 'smth': " + list["smth"]);
            WriteLine("Количество пар: " + list.Length);
        }
    }
}