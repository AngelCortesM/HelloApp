partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;
        Console.WriteLine($"x: {x}, y: {y}"); // x: 5, y: 15
        Person person1 = new Person
        {
            Name = "Carlos"
        };
        Person person2 = person1;
        person2.Name = "Ana";
        Console.WriteLine($"person1: {person1.Name}, person2: {person2.Name}"); // person1: Ana, person2: Ana
    }
}

class Person
{
    public string? Name { get; set; }

}