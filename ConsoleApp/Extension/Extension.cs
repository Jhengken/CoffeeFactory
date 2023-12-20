namespace ConsoleApp.Extension;

public static class Extension
{
    public static string StringJoin<T>(this IEnumerable<T> enumerable, string s)
    {
        return string.Join(s,enumerable);
    }
}
