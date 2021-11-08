using System;

namespace _001_Calculator.Components
{
    class CalculatorViews
    {
        public void StartMenu()
        {
            int elementCount = 56;
            string msg = "Welcome to Calculator";
            int pad = (elementCount - msg.Length) / 2;

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

            int padding = 4;
            string message = $"{"|".PadRight(padding)} choose opperation (+) : (-) : (*) : (\\) : (ESC){"|".PadLeft(padding)}";

            Console.WriteLine(new string('-', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('-', message.Length));
        }
    }
}
