using System.Security.Cryptography;

class Book
{
    string _name;
    string _author;
    double _price;

    public Book(string name, string Author, double price)
    {
        _name = name;
        _author = Author;
        _price = price;
    }

    public string Name => _name;
    public double Price
    {
        get => _price;
        set => _price = value;
    }
    public string Author => _author;


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}\nAuthor: {_author}\nPrice: {_price}");
    }

    public void ApplyDiscount(double percent)
    {
        _price = _price * (1 - percent / 100);
        Console.WriteLine($"Price after discount: {_price}");
    }

    public bool IsExpensive()
    {
        return _price > 10;
    }
}