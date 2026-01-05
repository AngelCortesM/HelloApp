using static System.Console;
partial class Program
{
    static void Loops()
    {
        // while
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración {counter}");
            counter++;
        }
        // do-while
        int number = 0;
        do
        {
            WriteLine($"Número {number}");
            number++;
        } while (number < 3);

        //for 
        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Iteración: {i}");
        }
       //personalizado
        for (int i = 10; i >= 0; i -= 2){
            WriteLine($"Cuenta regresiva: {i}");
        }
        // foreach
        //array
        string[] fruits = { "Manzana", "Banana", "Cereza" };
        foreach (var fruit in fruits)
        {
            WriteLine($"Fruta: {fruit}");
        }
        //lista
        List<string> names = ["Ana", "Luis", "Carlos"];
        foreach (var name in names)
        {
            WriteLine($"Nombre: {name}");
        }
    }
}