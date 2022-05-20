using static System.Console;

bool IsBalanced(string s)
{
   int count = 0;
   for (int i = 0; i < s.Length; i++)
   {
       if (s[i] == '(') count++;
       if (s[i] == ')') count--;
       if (count < 0) return false;
    }
    if (count == 0) return true;
    return false;
}

Write("Введите строку: ");
string s = ReadLine();

if (IsBalanced(s))
{
    WriteLine("Скобки расставленны верно");
}
else
{
    WriteLine("Скобки расставленны неверно");
}