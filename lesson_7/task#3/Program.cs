using static System.Console;
using static System.Convert;

Write("Введите предложение: ");
string line = ReadLine();
string[] words = line.Split(' ');
if (words.Length >= 2)
{
    var temp = words[words.Length - 1];
    words[words.Length - 1] = words[0];
    words[0] = temp;

    line = String.Join(' ', words);


    WriteLine(line);
    if (words.Length >= 3)
    {
        line = line.Remove(line.LastIndexOf(' '), 1);
        WriteLine(line);

        words = line.Split(' ');
        words[2] = Reverse(words[2]);

        line = String.Join(' ', words);
        WriteLine(line);
    }
    else 
    { 
        WriteLine("Введите больше, чем 3 слова"); 
    }
}
if (words.Length >= 1 && words[0].Length >= 2)
{
    line = line.Substring(2);
    WriteLine(line);
}
else
{
    WriteLine("Первое слово содержит меньше 3 символов");
}


static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}