using ConsoleApp.Enum;
using ConsoleApp.Interface;

namespace ConsoleApp.coffeeMaker;

public class OriginalCoffeeMaker : ICoffeeMaker
{
    private Taste Taste => Taste.Original;

    public async Task<List<Coffee>> GenerateCoffee()
    {
        System.Console.WriteLine($"準備生產{Taste.ToString()}");
        await Task.Delay(100);
        var list = new List<Coffee>();

        for(int i = 0; i < 6; i++)
        {
            list.Add(new Coffee(Taste));
        }

        System.Console.WriteLine($"已生產一組{Taste.ToString()}");
        return list;
    }
}