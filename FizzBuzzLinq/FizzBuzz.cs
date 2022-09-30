namespace FizzBuzzLinq;

public static class FizzBuzz
{
    public static IEnumerable<string> Translate(int number)
    {
        return Enumerable.Range(1, number)
            .Select(key => (Key: key, Value: string.Empty))
            .Select(data => data.Key % 3 == 0 ? data with { Value = "Fizz" } : data)
            .Select(data => data.Key % 5 == 0 ? data with { Value = data.Value + "Buzz" } : data)
            .Select(data => string.IsNullOrEmpty(data.Value) ? data with { Value = data.Key.ToString() } : data)
            .OrderBy(p => p.Key)
            .Select(p => p.Value);
    }
}