using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine("Enter student score(0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());
        char grade;
        if (score >= 75 && score <= 100)
        {
            grade = 'A';
        }
        else if (score >= 60)
        {
            grade = 'B';
        }
        else if (score >= 50)
        {
            grade = 'C';
        }
        else if (score >= 45)
        {
            grade = 'D';
        }
        else if (score >= 40)
        {
            grade = 'E';
        }
        else if (score >= 0)
        {
            grade = 'F';
        }
        else
        {
    Console.WriteLine("Invalid score entered.");
    return;
}
Console.WriteLine($"The student's grade is: {grade}");
    }
}