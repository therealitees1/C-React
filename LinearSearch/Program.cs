//1. PLAN (What the program will do)

//Store a list (array) of numbers

//Ask the user to enter a value to search

//Check each element one by one (linear search)

//If the value is found → display its position

//If not found → display “False”


//2. Design
//Use an array to store numbers
//Use a loop to iterate through the array
//Use conditional statements to check for a match

//3. Develop

using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 23, 45, 70, 11, 15, 90, 34, 67, 89 };

        int target = 70;
        bool found = false;
        foreach (int number in numbers)
        {
            if (number == target)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}


//4. Testing
//dotnet build
//dotnet run

//5. Deploy
//dotnet build
//dotnet run
//on a server

//6. Maintanance
//making improvements
//add a third number