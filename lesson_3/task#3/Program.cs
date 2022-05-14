    using static System.Console;
    using static System.Convert;
    
    public class rectangle
    {
        public static bool brake = false;
        int X, Y, Width, Height;
 
        public rectangle(int X, int Y, int width, int height)
        {
            this.X = X;
            this.Y = Y;
            this.Width = width;
            this.Height = height;
        }
        public void perem(int l, int h, ref int x, ref int y)
        {
            x -= l;
            y -= h;
        }
 
        public void sovm(int x1, int x2, int y1, int y2, int width1, int width2, int height1, int height2)
        {
 
            if (x1 > x2)
            {
                int buf = x1;
                x1 = x2;
                x2 = buf;
            }
            if (x1 + width1 < x2 + width2)
            {
                X = x1;
                Width = x2 - x1 + width2;
            }
            else
            {
                X = x1;
                Width = width2;
            }
            ////////////////////////
            if (y1 > y2)
            {
                int buf = y1;
                y1 = y2;
                y2 = buf;
            }
            if (y1 + height1 < y2 + height2)
            {
                Y = y1;
                Height = y2 - y1 + height2;
            }
            else
            {
                Y = y1;
                Height = height2;
            }
            Console.WriteLine("x={0},y={1},shirina={2},visota={3}", X, Y, Width, Height);
        }
 
        public void izm(int x, int y, ref int width, ref int height)
        {
            width -= x;
            height -= y;
        }
 
        public void show(int x, int y, int shirina, int visota)
        {
            Console.WriteLine("{0} {1} {2} {3}", x, y, shirina, visota);
        }
 
    }
    //-----------------------------------------------------------------------------------------------------------------------
    class Go
    {
        static void Main(string[] args)
        {
 
            WriteLine("Строим по левой нижней точке, высоте и длине");
            WriteLine("Варианты команд:\n Perem Izm Show Sovm Exit");
            WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            WriteLine("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            WriteLine("Введите ширину: ");
            int width = Convert.ToInt32(Console.ReadLine());
            WriteLine("Введите высоту: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int x2 = 3, y2 = 2, width2 = 3, height = 2;
            rectangle rect1 = new rectangle(x, y, width, height);
            // Здесь менять на сколько перемещать и изменять.
            int izmx = 1, izmy = 1;
            int perx = 1, pery = 1;
            //
            Console.WriteLine("Введите комманду: ");
            do
            {
                switch (Console.ReadLine())
                {
                    case "Perem": rect1.perem(perx, pery, ref x, ref y); break;
                    case "Izm": rect1.izm(izmx, izmy, ref width, ref height); break;
                    case "Show": rect1.show(x, y, width, height); break;
                    case "Sovm": rect1.sovm(x, x2, y, y2, width, width2, height, height); break;
                    case "Exit": rectangle.brake = true; break;
                    default: Console.WriteLine("Введите значения!"); break;
                }
            } while (!rectangle.brake);
        }
    }