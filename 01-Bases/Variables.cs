partial class Program
{
    static void Variables()
    {
        int age = 25;
        string name = "Jose Angel";
        bool isStudent = true;
        Console.WriteLine($"Name: {name} is {age} years old and is {(!isStudent ? "not " : "")}a student ");
    }
}