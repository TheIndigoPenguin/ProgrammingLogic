namespace Lab7;

class Book
{
    private string BookTitle;
    private string BookAuthor;

    public Book()
    {
        BookTitle = "Unknown Title";
        BookAuthor = "Unknown Author";
    }

    public Book(string title)
    {
        BookTitle = title;
        BookAuthor = "Unknown Author";
    }

    public Book(string title, string author)
    {

        BookTitle = title;
        BookAuthor = author;

    }

    public string GetAuthor()
    {

        return BookAuthor;

    }

    public string SetAuthor(string newAuthor)
    {

        BookAuthor = newAuthor;
        return BookAuthor;

    }
    public string GetTitle()
    {

        return BookTitle;

    }
    public string SetTitle(string newTitle)
    {

        BookTitle = newTitle;
        return BookTitle;

    }
}

class Program
{
    static void Main(string[] args)
    {

        //Problem 1

        Book book1 = new Book("Unknown Title");
        Console.WriteLine(book1.GetTitle());

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());

        Console.WriteLine(""); // Problem 2

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());

        Console.WriteLine(""); //Problem 3

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine(book3.GetTitle());
        Console.WriteLine(book3.GetAuthor());

        Console.WriteLine(""); //Problem 4

        Book book4 = new Book("Advanced C#", "John Doe");
        Console.WriteLine(book4.SetTitle("Mastering C#"));
        Console.WriteLine(book4.SetAuthor("Jane Smith"));



    }
}
