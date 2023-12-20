using ConsoleApp.Extension;

namespace ConsoleApp;

public class Logistics
{
    public List<Coffee> Box { get; set; }

    public string List()
    {
        return Box
            .Select(s => s.Name)
            .StringJoin(", ");
    }
}
