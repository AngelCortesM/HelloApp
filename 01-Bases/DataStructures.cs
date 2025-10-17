partial class Program
{
    static void DataStructures()
    {
        User pedro = new() { Name = "Pedro", Age = 30 };
        pedro.asignarNombre();
        pedro.Greet();
        Point punto = new Point { X = 5, Y = 10 };
        System.Console.WriteLine($"Punto coordenadas: ({punto.X}, {punto.Y})");
        CellPhome iphone = new CellPhome("iPhone 14", 999.99, "Apple");
        System.Console.WriteLine($"Teléfono: {iphone.Name}, Marca: {iphone.Brand}, Precio: ${iphone.Price}");
    }

}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {

        System.Console.WriteLine("Hola, soy " + Name + " y tengo " + Age + " años.");
    }

    public string asignarNombre()
    {
        this.Name = "Usuario1";
        System.Console.WriteLine("Nombre asignado: " + Name);
        return Name;
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

}

record CellPhome(string Name, double Price, string Brand);