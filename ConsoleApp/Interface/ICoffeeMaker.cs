namespace ConsoleApp.Interface;

public interface ICoffeeMaker
{
    public Task<List<Coffee>> GenerateCoffee();
}