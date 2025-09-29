partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416d;
        float floatingNumber = 3.14f;
        long LongNumber = 30_020_166L;
        decimal monetaryNumber = 99.99m;


        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Float: {floatingNumber}");
        Console.WriteLine($"Long: {LongNumber}");
        Console.WriteLine($"Decimal: {monetaryNumber}");


    }

}