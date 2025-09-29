partial class Program
{
    static void SalesReport()
    {
        string product
         = "Laptop";
        int quantitySold = 5;
        double unitPrice = 799.99;
        double totalAmount = quantitySold * unitPrice;
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad vendida: {quantitySold}");
        Console.WriteLine($"Precio unitario: {unitPrice:C}");
        Console.WriteLine($"Monto total: {totalAmount:C}");

    }

    static void SalaryCalculator()
    {
        Console.WriteLine("Calculadora de Salario");
        Console.WriteLine();
        Console.Write("Ingrese el salario base: ");
        string? name = Console.ReadLine();
        Console.Write("Ingrese las horas extras trabajadas: ");
        double hoursInput = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese la tarifa por hora extra: ");
        double rateInput = int.Parse(Console.ReadLine()!);
        double salary = hoursInput * rateInput;
        Console.WriteLine($"El salario total es: {salary:C}");
    }
}