
using System.Globalization;
using static System.Console;

partial class Program
{
    static void ConvertionDateTime()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-CO");

        int friends = int.Parse("101");
        double costo = 25.50;
        DateTime birthday = DateTime.Parse("2026-05-28");
        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"Mi cumpleaños es el {birthday:dd/MM/yyyy}");
        WriteLine($"Mi cumpleaños es el {birthday:MMMM dd, yyyy}");
        WriteLine($"Mi cumpleaños es el {birthday:D}");
        WriteLine($"El costo de la fiesta es {costo:C}");
    }
}