using static System.Console;
using static System.Math;

Random rnd = new Random();

int[] arr = new int[100];

for (int i = 0; i < 100; i++)
{
    arr[i] = rnd.Next(0, 10);
}

WriteLine($"Изначальный массив: {string.Join(' ', arr)}");

int max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == max)
    {
        arr[i] = 1;
    }
    else
    {
        arr[i] = 0;
    }
}

WriteLine($"Переделанный массив: {string.Join(' ', arr)}");