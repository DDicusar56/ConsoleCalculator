using System;

namespace _001_Calculator.Components
{
    internal static class Validation 
    { 
        public static (decimal, decimal) GetUserNumbers()
        {
            var num1 = UserDoubleValidation("Enter first number: ");
            var num2 = UserDoubleValidation("Enter second number: ");

            return (num1, num2);
        }

        private static decimal UserDoubleValidation(string requestMsg)
        {

            decimal result;

            Console.Write(requestMsg);

            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error :: Please enter a valid number ");
                Console.Write(requestMsg);
            }

            return result;
        }

        
    }
}
