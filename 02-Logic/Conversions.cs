using static System.Console;
partial class Program
{
    static void Conversions()
    {
        //Conversiones implícitas
        int number = 42;
        double decimalNumber = number; // int a double
        WriteLine($"Número entero: {number}, Número decimal: {decimalNumber}"); 
    }
}