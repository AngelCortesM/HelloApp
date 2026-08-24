partial class Program
{
    static void AnonymousFuntions()
    {
        System.Console.WriteLine(square(9));
        System.Console.WriteLine(Multiplique(9));
        System.Console.WriteLine(lambdaSquare(9));
        List<int> numbers = [1, 2, 3, 4, 5];
        var evenNumbers = numbers.Where(n => n > 2 && n < 5);
        foreach (var even in evenNumbers)
        {
            System.Console.WriteLine(even);
        }

    }

    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    static Func<int, int> lambdaSquare = x => x * x;
    static int Multiplique(int number)
    {
        return number * number;

    }

}