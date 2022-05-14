using static System.Console;

class Printing
{
    public string Title {get ; set;}
    public int PageCount {get; set;}

    public Printing(string title, int PageCount)
    {
        Title = title;
        PageCount = page_count;
    }
}

class Magazine : Printing
{
    public Magazine(string title, int page_count) : base(title, page_count)
    {
    }
}

class Book : Printing
{
    public string Author {get; set;}

    public Book (string author, string title, int page_count) : base(title, page_count)
    {
        Author = author;
    }
}

class TextBook : Book
{
    public int Year {get; set;}

    public TextBook (int year, string author, string title, int page_count) : base(author, title, page_count)
    {
        Year = year;
    }
}