using System;

try
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();

    var textStack = new Stack<char>();

    for (int i = 0; i < str.Length; i++)
        textStack.Push(str[i]);
// можео было сразу удалять
   /* foreach(var symbol in str)
    {
      if(symbol.Equals('#') & taxtStack.Count >0 )
      {
          textStack.Pop(symbol);
      }
        else 
      {
        textStack.Push(sumbol);      
      }
    }
*/
Console.WriteLine(EraseCharacters(textStack));
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string EraseCharacters(Stack<char> text)
{
    int counter = 0;
    string str = string.Empty;
//Можно было сразу удалять элементы в добавлении в стэк
    while (text.Count > 0)
    {
        char c = text.Pop();
        if (c == '#')
            counter++;
        else if (counter > 0)
            counter--;
        else str += c;
    }
    char[] chars = new char[str.Length]; //Эту строчку можно было вообще не делать, тогда
   // var chars = str.Select(x => x).ToArray(); но еще лучше
    //var chars = dtr.ToCharArray(); тогда
    chars = str.Select(x => x).ToArray(); //эта строчка не нужна
    Array.Reverse(chars);
    str = new string(chars);

    return str; //return new string(chars);
}
