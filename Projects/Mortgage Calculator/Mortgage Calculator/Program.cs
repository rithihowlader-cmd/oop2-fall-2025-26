using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        Console.WriteLine("=== Mortgage Calculator ===");

        double salary = 0;
        double creditScr = 0;
        bool criminalRcd = false;

        while (true)
        {
            Console.Write("Enter Your Monthly Salary: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out salary))
                break;
            else
                Console.WriteLine("Invalid Input! Please Enter a Numeric Value.");
        }

        while (true)
        {
            Console.Write("Enter your credit score (0 - 500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out creditScr))
            {
                if (creditScr >= 0 && creditScr <= 500)
                    break;
                else
                    Console.WriteLine("Credit Ccore must be between 0 and 500.");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please Enter a Numeric Value Between 0 And 500.");
            }
        }

        while (true)
        {
            Console.Write("Do You Have a Criminal Record? (True/False): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (input == "true")
            {
                criminalRcd = true;
                break;
            }
            else if (input == "false")
            {
                criminalRcd = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please Type 'True' or 'False'.");
            }
        }

        bool eligible = (creditScr >= 300) && !criminalRcd;

        if (!eligible)
        {
            Console.WriteLine("\nSorry, You Are Not Eligible For a Loan.");
            Console.WriteLine("Because, You Must Have a Good Credit Score (≥ 300) And No Criminal Record.");
            return;
        }

        double principal = 0;
        while (true)
        {
            Console.Write("Enter Your Desired Loan Amount: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out principal))
            {
                if (principal <= 2 * salary)
                    break;
                else
                    Console.WriteLine("Loan Request Denied. Cause, Loan Amount Must Be Under 2 Times Of Your Salary.");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please Enter a Numeric Value.");
            }
        }

        double annualInterestRate = 0;
        while (true)
        {
            Console.Write("Enter Annual Interest Rate (in %): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out annualInterestRate))
                break;
            else
                Console.WriteLine("Invalid Input! Please Enter a Numeric Value.");
        }

        int years = 0;
        while (true)
        {
            Console.Write("Enter loan period in years: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(input, out years))
                break;
            else
                Console.WriteLine("Invalid Input! Please Enter a Numeric Value.");
        }

        double monthlyRate = annualInterestRate / 100 / 12;
        int numberOfPayments = years * 12;

        double mortgage = principal *
            (monthlyRate * Math.Pow(1 + monthlyRate, numberOfPayments)) /
            (Math.Pow(1 + monthlyRate, numberOfPayments) - 1);

        double totalPayment = mortgage * numberOfPayments;
        double totalInterest = totalPayment - principal;

        Console.WriteLine();
        Console.WriteLine("====== Mortgage Summary ======");
        Console.WriteLine($"Monthly Salary: BDT {salary:0,0.00}");
        Console.WriteLine($"Credit Score: {creditScr}");
        Console.WriteLine($"Criminal Record: {criminalRcd}");
        Console.WriteLine($"Loan Amount: BDT {principal:0,0.00}");
        Console.WriteLine($"Annual Interest Rate: {annualInterestRate}%");
        Console.WriteLine($"Loan Period: {years} years");
        Console.WriteLine();
        Console.WriteLine($"Monthly Payment: BDT {mortgage:0,0.00}");
        Console.WriteLine($"Total Payment: BDT {totalPayment:0,0.00}");
        Console.WriteLine($"Total Interest: BDT {totalInterest:0,0.00}");

    }
}
