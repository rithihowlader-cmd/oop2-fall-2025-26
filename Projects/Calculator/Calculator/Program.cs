using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true;

        do
        {
            Console.WriteLine("Simple Calculator — choose an operation:");
            Console.WriteLine("  1) Addition");
            Console.WriteLine("  2) Subtraction");
            Console.WriteLine("  3) Multiplication");
            Console.WriteLine("  4) Division");
            Console.Write("Enter option number (1-4): ");

            string optionInput = Console.ReadLine();
            int option;
            while (!int.TryParse(optionInput, out option) || option < 1 || option > 4)
            {
                Console.Write("Please enter a number between 1 and 4: ");
                optionInput = Console.ReadLine();
            }

            Console.Write("Enter the first number: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("That wasn't a valid number. Please enter the first number again: ");
            }

            Console.Write("Enter the second number: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("That wasn't a valid number. Please enter the second number again: ");
            }

            double result = 0;
            bool validOperation = true;
            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        validOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.Write("Do you want to calculate another result? (y/n): ");
            string again = Console.ReadLine().Trim().ToLower();
            if (again != "y" && again != "yes")
            {
                keepRunning = false;
            }

            Console.WriteLine();
        }
        while (keepRunning);
    }
}
