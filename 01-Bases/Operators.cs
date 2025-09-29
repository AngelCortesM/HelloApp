partial class Program
{
    static void Operators()
    {
        int number = 12;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;
        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"{number} es par y mayor que 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"{number} es impar y mayor que 10");
        }
        else
        {
            Console.WriteLine($"{number}  no cumple las condiciones");
        }

        // Operador ternario (? :)
        int age = 21;
        string category = age > 18 ? "Adulto" : "Menor de edad";
        Console.WriteLine($"Categoría: {category}");

    }
}