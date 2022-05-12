using static System.Console;
using static System.Convert;

Console.Write("Введите вес яблок: ");
var weigth=ToDouble(ReadLine());

Console.Write("Введите цену яблок (кг/р): ");
var price=ToDouble(ReadLine());

Console.WriteLine($"Стоимость покупки: {weigth*price}");
