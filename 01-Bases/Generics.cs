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

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy una caja de texto" };
        numberBox.Show();
        stringBox.Show();
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
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Contenido de la caja: {Content}");
    }

}