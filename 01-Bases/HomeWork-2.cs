using System.Globalization;

partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Enter your birthday (dd/mm/aaaa):");
        string birthDateString = Console.ReadLine()!;
        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }
        int dayRemaining = (nextBirthday - currentDate).Days;
        Console.WriteLine($"Days until next birthday: {dayRemaining}");
    }
}