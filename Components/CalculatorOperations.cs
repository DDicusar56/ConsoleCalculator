using System;

namespace _001_Calculator.Components
{
    internal class CalculatorOperations
    {
        public void Addition()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Addition)} has been selected.");


            decimal num1, num2;
            (num1, num2) = Validation.GetUserNumbers();

            decimal result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");
        }

        public void Substraction()
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Substraction)} has been selected.");
            

            decimal num1, num2;
            (num1, num2) = Validation.GetUserNumbers();

            decimal result = num1 - num2;

            Console.WriteLine($"{num1} - {num2} = {result}");

        }

        public void Multiplication()
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Multiplication)} has been selected.");


            decimal num1, num2;
            (num1, num2) = Validation.GetUserNumbers();

            decimal result = num1 * num2;

            Console.WriteLine($"{num1} * {num2} = {result}");
        }

        public void Division()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\b \n");
            Console.WriteLine($"Opperation {nameof(Division)} has been selected.");

            try
            {
                decimal num1, num2;
                (num1, num2) = Validation.GetUserNumbers();

                decimal result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
