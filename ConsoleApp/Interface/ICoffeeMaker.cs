namespace ConsoleApp1.Interface;

public interface ICoffeeMaker
{
    public Task<List<Coffee>> GenerateCoffee();
}