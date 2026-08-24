partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        System.Console.WriteLine($"Tabla de multiplicar del número {number} desde el 1 hasta el {tableLimit}");
        System.Console.WriteLine();
        for (int i = 1; i <= tableLimit; i++)
        {
            System.Console.WriteLine($"{number} X {i} = {number * i}");
        }
        System.Console.WriteLine();
    }

    static void PrintFactorialTable(int number)
    {
        System.Console.WriteLine($"El factorial del numero {number} desde el 1 hasta el {number}");
        System.Console.WriteLine();
        for (int i = 1; i <= number; i++)
        {
            System.Console.WriteLine($"{i}! = {Factorial(i)}");
        }
    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}