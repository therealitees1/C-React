using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Area of a Circle Calculator");

        while (true)
        {
            Console.Write("Enter the radius (or type 'q' to quit): ");
            string input = Console.ReadLine();

            if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                break;

            if (!double.TryParse(input, out double radius))
            {
                Console.WriteLine("Invalid number. Please enter a valid numeric radius.");
                continue;
            }

            if (radius < 0)
            {
                Console.WriteLine("Radius cannot be negative. Please enter a positive number.");
                continue;
            }

            double area = Math.PI * radius * radius; // πr²
            Console.WriteLine($"Area = {area:F4}"); // formatted to 4 decimal places

            Console.WriteLine(); // blank line before next loop
        }

        Console.WriteLine("Goodbye!");
    }
}