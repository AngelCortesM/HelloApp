using System.Runtime.CompilerServices;

partial class Program
{
    static void ListDictionary()
    {
        List<string> names = ["Ana", "Carlos", "Juan"];
        names.Add("María");
        System.Console.WriteLine($"Total de nombres: {names.Count}");
        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }
        names.Remove("Carlos");
        System.Console.WriteLine("Eliminando a Carlos...");
        bool isPresent = names.Contains("Carlos");
        System.Console.WriteLine($"¿Carlos está en la lista? {isPresent}");

        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>{
            {1, "Ana"},
            {2, "Luis"},
            {3, "Marta"}
        };
        System.Console.WriteLine($"El estudiante con ID 2 es: {students.ElementAt(1)}");

        foreach (var student in students)
        {
            System.Console.WriteLine($"ID: {student.Key} - Nombre: {student.Value}");
        }

    }
}