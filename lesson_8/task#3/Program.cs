using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
var line = ReadLine();

Regex regex = new Regex(@"[0-9]");
MatchCollection matches = regex.Matches(line);

if (matches.Count > 0)
{
    WriteLine("Текст содержит цифры");
}
else
{
    WriteLine("Текст не содержит цифры");
}