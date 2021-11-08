using System;

namespace _001_Calculator.Components
{
    internal class CalculatorViews
    {
        public static void StartMenu()
        {
            const int elementCount = 56;
            var msg = "Welcome to Calculator";
            var pad = (elementCount - msg.Length) / 2;

            Console.WriteLine($"{" ".PadRight(pad)} {msg} {" ".PadLeft(pad)}");
            Console.WriteLine(new string('-', elementCount));
            Console.WriteLine("INFO : use symbol '.' for decimal delimitation !");
            Console.WriteLine("Press key for coresponding opperation :");
            Console.WriteLine(new string('-', elementCount));

            Console.WriteLine();
            Console.WriteLine("   KEYS     | OPERATION");
            Console.WriteLine(new string('-', elementCount));
            Console.WriteLine("  1 or  +   | addition");
            Console.WriteLine("  2 or  -   | substration");
            Console.WriteLine("  3 or  *   | multiplication");
            Console.WriteLine("  4 or  /   | division");
            Console.WriteLine("       ESC  | exit calculator");

            Console.WriteLine(new string('-', elementCount));
        }

        public void SelectNextOperation()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            // NOTE: padding const
            const int padding = 4;
            // NOTE: use var 
            var message = $"{"|".PadRight(padding)} choose opperation (+) : (-) : (*) : (\\) : (ESC){"|".PadLeft(padding)}";

            Console.WriteLine(new string('-', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('-', message.Length));
        }
    }
}
