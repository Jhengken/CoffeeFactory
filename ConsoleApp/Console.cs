using ConsoleApp1;
using ConsoleApp1.Enum;
using ConsoleApp1.Interface;

var originalMaker = GetCoffeeMaker(Taste.Original);
var caramelMaker = GetCoffeeMaker(Taste.Caramel);
var saltMaker = GetCoffeeMaker(Taste.Salt);

var original = originalMaker.GenerateCoffee();
var caramel = caramelMaker.GenerateCoffee();
var salt = saltMaker.GenerateCoffee();

var coffees = 
    (await Task.WhenAll(original, caramel, salt))
    .SelectMany(s => s)
    .ToList();

var logistics = new Logistics { Box = new List<IProduct>(coffees) };
var list = logistics.List();

Console.WriteLine($" 一箱 = [ {list} ]");



ICoffeeMaker GetCoffeeMaker(Taste taste)
{
    return new CoffeeFactory(taste).CoffeeMaker();
}
