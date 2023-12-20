using ConsoleApp1.Enum;
using ConsoleApp1.Interface;

namespace ConsoleApp1.coffeeMaker;

public class CaramelCoffeeMaker : ICoffeeMaker
{
    private readonly int _generateTime = 300;

    private Taste Taste => Taste.Caramel;

    public async Task<List<Coffee>> GenerateCoffee()
    {
        Console.WriteLine($"準備生產{Taste.ToString()}");
        await Task.Delay(_generateTime);
        var list = new List<Coffee>();

        for(int i = 0; i < 6; i++)
        {
            list.Add(new Coffee(Taste));
        }

        Console.WriteLine($"已生產一組{Taste.ToString()}");
        return list;
    }
}