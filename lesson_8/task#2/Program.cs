using static System.Console;
using System.Text.RegularExpressions;

Write("Введите строку: ");
string line = ReadLine();

Regex regex = new Regex(@"[А-я]");
MatchCollection matches = regex.Matches(line);

if (matches.Count > 0)
{
    WriteLine("Текс не на английском языке");
}
else
{
    WriteLine("Текс на английском языке");
}