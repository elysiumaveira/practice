using static System.Console;
using System.Text.RegularExpressions;

Write("Введите строку: ");
string line = ReadLine();

Regex regex = new Regex(@"(\w*-\w*){2}");
MatchCollection matches = regex.Matches(line);

if(matches.Count > 0)
{
    foreach(Match match in matches)
    {
        WriteLine($"В слове {match.Value} более одного дефиса");
    }
}
else
{
    WriteLine("хихи");
}