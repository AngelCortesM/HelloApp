using System.Net.WebSockets;

partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hola");

        System.Console.WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = (33, "Perro");

        System.Console.WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");
        var operations = Operations(5, 2);
        System.Console.WriteLine($"las operaciones son: Suma = {operations.Sum} y Resta ={operations.Subtraction}");
        (int sum, int sustraction) = Operations(25, 15);
        System.Console.WriteLine($"Suma :{sum} resta:{sustraction}");
    }

    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}