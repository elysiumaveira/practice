using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task3
{
    class Plans
    {
        public string name;
        public int countP;
        public Plans(string name, int countP)
        {
            this.name = name;
            this.countP = countP;
        }
        virtual public void PrintWeather()
        {
            Console.WriteLine($"В плане '{name}' количетво дел: {countP}");
        }
    }
    class InfoObj
    {
        public static void Info<tip>(tip obj)
        where tip : Plans
        {
            obj.PrintWeather();
        }
    }
    class Pl : IEnumerable
    {
        private ArrayList list;
        public Pl()
        {
            list = new ArrayList();
        }
        public Pl(ArrayList a)
        {
            list = a;
        }
        public void Add(Plans m)
        {
            list.Add(m);
        }
        public Pl Clone()
        {
            return new Pl(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _____Пример______ ");
            Plans dem = new Plans("Встретиться с Лизой", 4);
            InfoObj.Info<Plans>(dem);
            Console.WriteLine(" _________________ ");
            Pl plan_list = new Pl();
            Dictionary <int, string>hike = new Dictionary<int, string>(3);
            for (int i = 0; i <3; i++)
            {
                Console.Write("Введите название плана: ");
                string w = null;
                w = Console.ReadLine();
                Console.Write("Введите количество дел в плане: ");
                int g =Convert.ToInt32(Console.ReadLine());
                
                plan_list.Add(new Plans(w, g));
                hike[i + 1] = w;
            }
            Console.WriteLine("============ ");
            foreach (KeyValuePair < int, string> keyValue in hike)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
            Console.WriteLine("============ ");
            foreach (Plans x in plan_list)
                x.PrintWeather();
            plan_list.RemoveAt(1);
            Console.WriteLine("============ ");
            Pl pl = (Pl)plan_list.Clone();
            foreach (Plans x in pl) x.PrintWeather();
            Console.ReadLine();
        }
    }
}