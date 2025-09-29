partial class Program
{
    static void HandleNullables()
    {
        // No nulificable
        string firstName = "Carlos";
        // Nunificable
        string? lastName = null;
        Console.WriteLine($"Nombre: {firstName}");
        if (lastName != null) { Console.WriteLine($"Apellido: {lastName}"); }
        else
        {
            Console.WriteLine("Apellido: No especificado");
        }
        // Operador de coalescencia nula
        Console.WriteLine($"Apellido: {lastName ?? "No especificado!"}");
        // Operador de acceso nulo seguro
        string? text = null;
        Console.WriteLine($"Longitud del texto: {text?.Length}");
    }
}