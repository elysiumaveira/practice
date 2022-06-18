using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2_flowers;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int n = 3;
            flowers[] material = new flowers[n];
            material[0] = new flowers.Roses(rnd.Next(1, 6), "Красные", rnd.Next(0, 20), "Душистые");
            material[1] = new flowers.Tulips(rnd.Next(1, 6), "Жёлтые", rnd.Next(0, 20), "Обыкновенные");
            material[2] = new flowers.Pionies(rnd.Next(1, 6), "Белые", rnd.Next(0, 20), "Японские");
            foreach (flowers elem in material)
            {
                elem.Description();
                elem.Sr();
            }
            Console.ReadLine();
        }
    }
}
