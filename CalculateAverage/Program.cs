using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers? ");
        int count = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter number " + i + ": ");
            sum += double.Parse(Console.ReadLine());
        }

        double average = sum / count;
        Console.WriteLine("Average = " + average);
    }
}
