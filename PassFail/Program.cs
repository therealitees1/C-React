// using an array
using System;

class Program
{
    static void Main()
    {
        int[] scores = { 45, 78, 62, 30, 90, 49 };

        int pass = 0;
        int fail = 0;

        foreach (int score in scores)
        {
            if (score >= 50)
                pass++;
            else
                fail++;
        }

        Console.WriteLine("Pass count = " + pass);
        Console.WriteLine("Fail count = " + fail);
    }

// using user input
    static void Main_UserInput()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int pass = 0, fail = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter score for student " + i + ": ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 50)
                pass++;
            else
                fail++;
        }

        Console.WriteLine("Pass = " + pass);
        Console.WriteLine("Fail = " + fail);
    }
}
