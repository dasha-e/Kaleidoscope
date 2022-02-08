using System;

namespace Kaleidoscope
{
    class Program
    {
        static Random random = new Random();
        static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)random.Next(1, 15);
        }

        static void Kaliedoscope(int n)
        {
            ConsoleColor[,] partK = new ConsoleColor[n, n];
            for (int i = 0; i < n; i++) partK[i, i] = GetRandomConsoleColor();
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    partK[i, j] = GetRandomConsoleColor();
                    partK[j, i] = GetRandomConsoleColor();
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.BackgroundColor = partK[i, j];
                    Console.Write(" ");
                }
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.BackgroundColor = partK[i, j];
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.BackgroundColor = partK[i, j];
                    Console.Write(" ");
                }
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.BackgroundColor = partK[i, j];
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the kaleidoscope (half the side of the square). Valid values [3; 20].");
            if (Int32.TryParse(Console.ReadLine(), out int n) && n > 2 && n < 21) Kaliedoscope(n);
            else Console.WriteLine("Error: Invalid value entered.");
            Console.Write("Press any key to finish.");
            Console.ReadKey();
        }
    }
}
