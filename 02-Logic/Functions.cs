
partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }
    static string EvaluateNumber(int number)
    {
        if (number > 0) return "Positivo";
        else if (number < 0) return "Negativo";
        else return "Cero";
    }
    static void Functions()
    {
        var area = CalculateArea(5, 10);
        Console.WriteLine($"El área del rectángulo es: {area}");
        var evaluated = EvaluateNumber(-45);
        System.Console.WriteLine($"El numero es:  {evaluated}");
    }
}