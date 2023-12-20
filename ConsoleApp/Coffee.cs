using ConsoleApp1.Enum;
using ConsoleApp1.Interface;

namespace ConsoleApp1;

public class Coffee : IProduct
{
    private readonly Taste _taste;

    public Coffee(Taste taste)
    {
        _taste = taste;
        Name = taste.ToString() + nameof(Coffee);
    }

    public string TasteStr => _taste.ToString();

    public string Name { get; set; }
}