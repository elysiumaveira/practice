using static System.Console;

namespace task3
{
    class MyInfo
    {
        private string name = "Vladislav";
        public delegate void MyInfoDel(string message);
        public event MyInfoDel? Call;

        public string Name
        {
            get
            {
                return name;    // возвращаем значение свойства
            }
            set
            {
                Call?.Invoke($"Значение поля name измененно с {name} на {value}");   // 2.Вызов события 
                name = value;   // устанавливаем новое значение свойства
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyInfo m = new MyInfo();
            m.Call += DisplayMessage;
            m.Name = "Vladislav Semenenya";
            void DisplayMessage(string message) => WriteLine(message);
        }
    }
}