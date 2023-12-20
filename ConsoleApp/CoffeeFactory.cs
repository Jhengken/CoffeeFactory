using ConsoleApp.coffeeMaker;
using ConsoleApp.Enum;
using ConsoleApp.Interface;

namespace ConsoleApp;

public class CoffeeFactory(Taste taste)
{
    public ICoffeeMaker CoffeeMaker()
    {
        return taste switch
        {
            Taste.Original => new OriginalCoffeeMaker(),
            Taste.Salt => new SaltCoffeeMaker(),
            Taste.Caramel => new CaramelCoffeeMaker(),
            _ => throw new Exception("沒有這個口味")
        };
    }
}