partial class Program
{
    static void ShowStringTypes()
    {

        string name = "Juan";
        string message = "Hello " + name;
        string interpolatedMessage = $"       Hello {name},    bienvenido a C# 13.0";
        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"La cadena tiene {interpolatedMessage.Length} caracteres");
        Console.WriteLine($"La cadena en mayúsculas: {interpolatedMessage.ToUpper()}");
        Console.WriteLine($"La cadena en minúsculas: {interpolatedMessage.ToLower()}");
        Console.WriteLine($"La cadena sin espacios: {interpolatedMessage.Trim()}");

        int number = 42;
        Console.WriteLine($"El número {number} como cadena es '{number.ToString()}'");
        bool isString = true;
        Console.WriteLine($"El valor booleano {isString} como cadena es '{isString.ToString()}'");


    }

}