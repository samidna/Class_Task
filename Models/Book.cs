namespace Class.Models;

public class Book
{
    public string Name;
    public int PageCount;

    public Book(string name, int pageCount)
    {
        Name=name;
        PageCount=pageCount;
    }
}
