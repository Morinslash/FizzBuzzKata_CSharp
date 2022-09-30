namespace FizzBuzzLinq;

public static class FizzBuzz
{
    public static string[] Translate(int number)
    {
        return Enumerable.Range(1, number)
            .Select(n => n%3 == 0 ? "Fizz" : n.ToString())
            .ToArray();
    }
}