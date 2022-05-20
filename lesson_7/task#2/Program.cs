using static System.Console;

Write("Введите строку: ");
string s = ReadLine();

string StripUppercase(string s)
{
    int i = 0;
    char[] chars = new char[s.Length];
    foreach (char c in s)
        if (!char.IsUpper(c))
            chars[i++] = c;
    return new string(chars, 0, i);
}

WriteLine(StripUppercase(s));