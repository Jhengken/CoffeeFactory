using ConsoleApp1.Extension;
using ConsoleApp1.Interface;

namespace ConsoleApp1;

public class Logistics
{
    public List<IProduct> Box { get; init; }

    public string List()
    {
        return Box
            .Select(s => s.Name)
            .StringJoin(", ");
    }
}
