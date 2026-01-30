using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter first number (or 'q' to quit): ");
            string input = Console.ReadLine();
            if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                break;

            if (!double.TryParse(input, out double left))
            {
                Console.WriteLine("Invalid number. Try again.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();
            if (string.Equals(op, "q", StringComparison.OrdinalIgnoreCase))
                break;

            if (op != "+" && op != "-" && op != "*" && op != "/")
            {
                Console.WriteLine("Invalid operator. Use +, -, * or /.");
                continue;
            }

            Console.Write("Enter second number (or 'q' to quit): ");
            string input2 = Console.ReadLine();
            if (string.Equals(input2, "q", StringComparison.OrdinalIgnoreCase))
                break;

            if (!double.TryParse(input2, out double right))
            {
                Console.WriteLine("Invalid number. Try again.");
                continue;
            }

            try
            {
                double result = op switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => right == 0 ? throw new DivideByZeroException() : left / right,
                    _ => throw new InvalidOperationException("Unknown operator")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}