using static System.Console;

WORKER[] worker = new WORKER[10];
for (int i = 0; i < worker.Length; i++)
{
    Write("ФИО: ");
    worker[i].fio = ReadLine();
    Write("Должность: ");
    worker[i].post = ReadLine();
    Write("Год: ");
    worker[i].year = ReadLine();
}
worker = worker.OrderBy(x => x.fio).ToArray();
string tp = "";
bool had = false;
do
{
    Write("\nВведите год для поиска: ");
    tp = ReadLine();
    WriteLine($"\nWORKER: {tp}");

    for (int i = 0; i < worker.Length; i++)
    {
        if (tp == worker[i].year)
        {
            WriteLine($"ФИО: {worker[i].fio}");
            WriteLine($"Должность: {worker[i].post}");
            had = true;
        }
    }
    if (!had)
    {
        Console.WriteLine($"Не найден: {tp}");
    }
    had = false;
    WriteLine("\nХотите продолжить? (y/n)");
}
while (ReadLine() != "n");
public struct WORKER
{
    public string fio;
    public string post;
    public string year;
}