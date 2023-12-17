using System;

namespace Lab_6_task_1
{
    class Program
    {
        static void Main(string[] args)
        { 
        ArithmeticCalculator<int> intCalculator = new ArithmeticCalculator<int>();
        ArithmeticCalculator<double> doubleCalculator = new ArithmeticCalculator<double>();

        Console.WriteLine("Choose an operation (1 - add, 2 - subt., 3 - mult., 4 - div.):");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    PerformCalculation(intCalculator, doubleCalculator, choice, num1, num2);
                }
                else
                {
                    Console.WriteLine("Error: Incorrect input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Error: Incorrect input for the first number.");
            }
        }
        else
        {
            Console.WriteLine("Error: Incorrect input for operation selection.");
        }
    }

    static void PerformCalculation(ArithmeticCalculator<int> intCalculator, ArithmeticCalculator<double> doubleCalculator, int choice, double num1, double num2)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {intCalculator.PerformOperation((int)num1, (int)num2, intCalculator.Add)}");
                break;
            case 2:
                Console.WriteLine($"Result: {intCalculator.PerformOperation((int)num1, (int)num2, intCalculator.Subtract)}");
                break;
            case 3:
                Console.WriteLine($"Result: {doubleCalculator.PerformOperation(num1, num2, doubleCalculator.Multiply)}");
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine($"Result: {doubleCalculator.PerformOperation(num1, num2, doubleCalculator.Divide)}");
                else
                    Console.WriteLine("Error: Division by zero.");
                break;
            default:
                Console.WriteLine("Incorrect operation selection.");
                break;
        }
        }
    }
}