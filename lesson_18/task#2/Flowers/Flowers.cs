using System;

namespace task2_flowers
{
    public abstract class flowers
    {
        public abstract void Description();
        public abstract void Sr();
        public class Roses : flowers
        {
            public Roses(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Розы {type} Цвет: {color} Количество: {col} Цена: {Cost}");
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Розы отсутствуют");
                if (Cost == 0) System.Console.WriteLine("Розы дорогие");
                else System.Console.WriteLine("Розы дешевые");
            }
        }
        public class Tulips : flowers
        {
            public Tulips(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Тюльпаны {type} Цвет: {color} Количество: {col} Цена: {Cost}");
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Тюльпаны отсутствует");
                if (Cost == 0) System.Console.WriteLine("Тюльпаны дорогие");
                else System.Console.WriteLine("Тюльпаны дешевые");
            }
        }
        public class Pionies : flowers
        {
            public Pionies(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Description()
            {
                System.Console.WriteLine($"Пионы {type} Цвет: {color} Количество: {col} Цена: {Cost}");
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Пионы отсутствуют");
                if (Cost == 0) System.Console.WriteLine("Пионы дорогие");
                else System.Console.WriteLine("Пионы дешевые");
            }
        }
    }
}
