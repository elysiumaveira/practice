using static System.Console;
using static System.Convert;

Write("Введите номер телевизионного канала (1-5): ");
var channel = ToInt16(ReadLine());

switch (channel)
{
    case 1:
        WriteLine("Наша Раша, CamedyClub, CamedyWomen");
        break;
    case 2:
        WriteLine("Новости, Прогноз погоды");
        break;
    case 3:
        WriteLine("Следствие вели с Леонидом Каневским, Мухтар, Улица разбитых фонарей");
        break;
    case 4:
        WriteLine("Брат (1, 2)");
        break;
    case 5:
        WriteLine("Новости, Прогноз погоды, Анекдоты");
        break;
    default:
        break;
}
