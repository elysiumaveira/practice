using static System.Console;
using static System.Convert;

namespace task_1
{
    class Table
    {
        public string table_name { get; set; }
        public double yardage { get; set; }

        public Table(double yardage)
        {
            this.yardage = yardage;
        }

        public double GetPrice(double k, double yardage)
        {
            double price = (yardage*2) / (3+k);

            return price;
        }
    }

    class Desk : Table
    {
        public Desk(double yardage) : base(yardage)
        {
            this.yardage = yardage;
        }

        public string material { get; set; }
        public double finishing_cost { get; set; }

        public double GetFinishingCost(double k, double yardage)
        {
            finishing_cost = base.GetPrice(k, yardage) * 0.1;

            return finishing_cost;
        }

        public double GetFullPrice(double k, double yardage)
        {
            double full_price = GetFinishingCost(k, yardage) + base.GetPrice(k, yardage);

            return full_price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите название стола: ");
            string table_name = ReadLine();

            Write("Введите площадь: ");
            double yardage = ToDouble(ReadLine());

            Write("Введите материал: ");
            string material = ReadLine();

            Write("Введите коэффициент: ");
            double k = ToDouble(ReadLine());

            Table table = new Table(yardage);
            Desk desk = new Desk(yardage);

            WriteLine($"{desk.GetFullPrice(k, yardage)}");
        }
    }
}