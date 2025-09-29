partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        //Directa
        int[] numbersArray = [10, 2, 3, 40, 5];
        //Indices
        Console.WriteLine($"Primer número: {numbersArray[0]}");
        Console.WriteLine($"Tercer número: {numbersArray[2]}");
        //Tamaño arreglo
        Console.WriteLine($"Tamaño del arreglo: {numbersArray.Length}");
    }
}