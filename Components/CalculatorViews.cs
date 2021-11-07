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
            Console.WriteLine("Press key for coresponding opperation :");
            Console.WriteLine(new string('-', elementCount));

            Console.WriteLine("(+)   addition");
            Console.WriteLine("(-)   substration");
            Console.WriteLine("(*)   multiplication");
            Console.WriteLine("(/)   division");
            Console.WriteLine("(ESC) exit calculator");

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
