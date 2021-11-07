using System;

namespace _001_Calculator.Components
{
    class CalculatorOperations
    {
        private readonly Validation validation = new Validation();

        public void Addition()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Addition)} has been selecte.");


            double num1, num2;
            (num1, num2) = validation.GetUserNumbers();

            double result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");
        }

        public void Substraction()
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Substraction)} has been selecte.");
            

            double num1, num2;
            (num1, num2) = validation.GetUserNumbers();

            double result = num1 - num2;

            Console.WriteLine($"{num1} - {num2} = {result}");

        }

        public void Multiplication()
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Multiplication)} has been selecte.");
            

            double num1, num2;
            (num1, num2) = validation.GetUserNumbers();

            double result = num1 * num2;

            Console.WriteLine($"{num1} * {num2} = {result}");
        }

        public void Division()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Division)} has been selecte.");
            

            double num1, num2;
            (num1, num2) = validation.GetUserNumbers();

            double result = num1 / num2;

            if (Double.IsInfinity(result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error :: Division by Zero is not allowed");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {result}");
            }
        }
    }
}
