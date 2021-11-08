using System;
using _001_Calculator.Components;

namespace _001_Calculator
{
    class Calculator
    {

        private static CalculatorOperations operation = new CalculatorOperations();
        private static CalculatorViews view = new CalculatorViews();
        
        public static void Start()
        {
            #region Console Configuration (WindowsOnly)
#pragma warning disable CA1416 // Validate platform compatibility
            Console.SetWindowSize(58, 30);
#pragma warning restore CA1416 // Validate platform compatibility
            #endregion

            view.StartMenu();

            while (true)
            {
                var userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.Add: case ConsoleKey.D1:
                        operation.Addition();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Subtract: case ConsoleKey.D2:
                        operation.Substraction();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Multiply: case ConsoleKey.D3:
                        operation.Multiplication();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Divide: case ConsoleKey.D4:
                        operation.Division();
                        view.SelectNextOperation();

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
