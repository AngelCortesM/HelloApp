partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Ana", "Luis" };
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Tamaño del arreglo de nombre: {GetStringArrayLength(names)}");
        Console.WriteLine($"Tamaño del arreglo de numeros: {GetIntArrayLength(numbers)}");
        Console.WriteLine($"Tamaño del arreglo de nombre (Genérico): {GetArrayLength<string>(names)}");
        Console.WriteLine($"Tamaño del arreglo de numeros (Genérico): {GetArrayLength<int>(numbers)}");
    }
    //metodos sin usar genericos
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }
    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }
    //metodo generico
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;

    }
}

class Box<T>
{
    private T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Contenido de la caja: {Content}");
    }

}