using System;

namespace _001_Calculator.Components
{
    class Validation
    {
        private double UserDoubleValidation(string requestMsg)
        {

            double result;

            Console.Write(requestMsg);

            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Error :: Please enter a valid number ");
                Console.Write(requestMsg);
            }
            return result;
        }

        public (double, double) GetUserNumbers()
        {
            double num1, num2;

            num1 = UserDoubleValidation("Enter first number: ");
            num2 = UserDoubleValidation("Enter second number: ");

            return (num1, num2);
        }
    }
}
