partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Laptop", "Tablet", "Smartphone", "Monitor"];
        int[] stock = [10, 25, 15, 8];
        double[] prices = [999.99, 499.99, 799.99, 199.99, 55];
        //Menu de Opciones
        Console.WriteLine("1. Comprar Producto");
        Console.WriteLine("2. Salir");
        Console.WriteLine("Seleccione una opción: ");
        int option = int.Parse(Console.ReadLine()!);
        if (option == 1)
        {

            Console.WriteLine("Inventario de Productos:");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]} - Stock: {stock[i]} - Precio: ${prices[i]}");
            }
            Console.WriteLine("\nIngrese el producto que desea comprar:");
            string? searchedProduct = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad que desea comprar:");
            int quantity = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double total = quantity * prices[i];
                        Console.WriteLine($"Compra exitosa! Total a pagar: ${total:C}");
                        Console.WriteLine($"Para el producto: {searchedProduct} el stock restante: {stock[i] - quantity} unidades.");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock para completar la compra.");
                    }
                }
            }
        }
        if (option == 2)
        {
            Console.WriteLine("Gracias por visitar nuestra tienda!");
            return;
        }
        else
        {
            Console.WriteLine("Opción no válida. Saliendo del programa.");
        }

    }
}