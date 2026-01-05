using static System.Console;
partial class Program
{
    static void LoopsControlsExamples()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            WriteLine($"Número {i}");
        }
        WriteLine("-----");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue;
            }
            WriteLine($"Número {i}");
        }
        WriteLine("-----");
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                // return;
            }
            WriteLine($"Número {i}");
        }
        //bucle infinito con while o for
        while (true)
        {
            WriteLine("Bucle infinito con while");
            break;

        }
        for (; ; )
        {
            WriteLine("Bucle infinito con for");
            break;
        }
    }
}