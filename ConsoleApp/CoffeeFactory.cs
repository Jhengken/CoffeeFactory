using ConsoleApp1.coffeeMaker;
using ConsoleApp1.Enum;
using ConsoleApp1.Interface;

namespace ConsoleApp1;

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