using System;
using _001_Calculator.Components;

namespace _001_Calculator
{
    internal static class Calculator
    {

        private static readonly CalculatorOperations Operation = new ();
        private static readonly CalculatorViews View = new ();
        
        public static void Start()
        {
            CalculatorViews.StartMenu();

            while (true)
            {
                var userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.Add: case ConsoleKey.D1:
                        Operation.Addition();
                        View.SelectNextOperation();
                        break;
                    case ConsoleKey.Subtract: case ConsoleKey.D2:
                        Operation.Substraction();
                        View.SelectNextOperation();
                        break;
                    case ConsoleKey.Multiply: case ConsoleKey.D3:
                        Operation.Multiplication();
                        View.SelectNextOperation();
                        break;
                    case ConsoleKey.Divide: case ConsoleKey.D4:
                        Operation.Division();
                        View.SelectNextOperation();

                        break;
                    case ConsoleKey.Escape:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return;
                    default:
                        Console.Write("\b  \r");
                        break;
                }
            }


        }
    }
}
