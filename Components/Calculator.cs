using System;

namespace _001_Calculator.Components
{
    class Calculator
    {

        private readonly CalculatorOperations operation = new CalculatorOperations();
        private readonly CalculatorViews view = new CalculatorViews();
        
        public void Start()
        {
            //Window size configuration
            {
#pragma warning disable CA1416 // Validate platform compatibility
                Console.SetWindowSize(58, 30);
#pragma warning restore CA1416 // Validate platform compatibility
            }

            view.StartMenu();

            while (true)
            {
                var userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.Add:
                        operation.Addition();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Subtract:
                        operation.Substraction();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Multiply:
                        operation.Multiplication();
                        view.SelectNextOperation();
                        break;
                    case ConsoleKey.Divide:
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
