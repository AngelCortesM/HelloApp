using static System.Console;
partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🎮 ¡Pulse cualquier tecla para aumentar el contador!");
        WriteLine("📤 Pulse 'ESC' para salir del juego.\n");
        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {

                WriteLine($"Haz pulsado {counter} veces el contador. ¡Hasta luego! 👋");
                WriteLine("○ • • • • • ○ > Programa finalizado. 😊");
                break;
            }
            counter++;
            WriteLine($"🔢 Contador: {counter}");
        }
    }
}