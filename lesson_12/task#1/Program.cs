using static System.Convert;
using static System.Console;

namespace task1
{
    class Clothes
    {
        public string name;
        public Clothes()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Write("Введиете название (пальто/костюма): ");
            name = ReadLine();
        }
        public virtual void GetInfo()
        {
            WriteLine($"название: {name}");
        }
    }

    class Coat : Clothes
    {
        public double V;
        public double consumption;
        public Coat()
        {
            this.V = 0.0;
            this.consumption = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите размер: ");
            V = ToDouble(ReadLine());
        }
        public virtual void Consumption()
        {
            consumption = V/6.5 + 0.5;
        }
        public override void GetInfo()
        {
            Consumption();
            WriteLine($"Название: {name}\n размер: {V}\n расход ткани: {consumption}");
        }
    }

    class Costume : Clothes
    {
        public double H;
        public double consumption;
        public Costume()
        {
            this.H = 0.0;
            this.consumption = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите рост: ");
            H = ToDouble(ReadLine());
        }
        public virtual void Consumption()
        {
            consumption = H * 2.5;
        }
        public override void GetInfo()
        {
            Consumption();
            WriteLine($"Название: {name}\n рост: {H}\n расход ткани: {consumption}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.Пальто\n2.Костюм");
            WriteLine("Выберите создаваемый объект:");
            int change = ToInt32(ReadLine());
            int i = 0;
            double sum = 0;
            Console.Write("Введите количество объектов: ");
            int mascount = ToInt32(ReadLine());
            Clothes[] clothes = new Clothes[mascount];
            while (i< mascount)
            {
                switch (change)
                {
                    case 1: 
                        Coat coat = new Coat();
                        coat.Consumption();
                        sum += coat.consumption;
                        clothes[i] = coat as Clothes;++i;
                        break;

                    case 2: Costume costume = new Costume();
                        costume.Consumption();
                        sum += costume.consumption;
                        clothes[i] = costume as Clothes;++i;
                        break;

                    default: 
                            WriteLine("Данного пункта не существует");
                            break;
                }
            }
            for (int t = 0; t < clothes.Length; t++)
            {
                if (clothes[t] != null)
                {
                    clothes[t].GetInfo();
                }
            }
            WriteLine("суммарный расход ткани: "+ sum);
        }
    }
}
