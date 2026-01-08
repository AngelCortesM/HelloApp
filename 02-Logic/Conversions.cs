using static System.Console;
using static System.Math;
partial class Program
{
    static void Conversions()
    {
        // Conversiones implícitas
        int number = 42;
        double decimalNumber = number; // int a double
        WriteLine($"Número entero: {number}, Número decimal: {decimalNumber}");

        double explicitDecimalNumber = 42.6;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine($"Número decimal: {explicitDecimalNumber}, Número entero (después de conversión explícita): {integerNumber}");

        //Convert o Parse
        // Parse
        string text = "12345";
        int parsedNumber = int.Parse(text);
        WriteLine($"Texto: {text}, Número parseado: {parsedNumber}");

        // Convert
        double anotherDecimalNumber = 67.89;
        int parsedFloat = Convert.ToInt32(anotherDecimalNumber);
        WriteLine($"Texto: {anotherDecimalNumber}, Número decimal parseado: {parsedFloat}");//redondea
        int castedNumber = (int)anotherDecimalNumber;
        WriteLine($"Texto: {anotherDecimalNumber}, Número decimal casteado: {castedNumber}");//trunca
    }

}