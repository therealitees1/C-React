// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Itohowo Nkanang");
Console.WriteLine("I am learning C# programming.");
Console.WriteLine("This is my first C# application.");
Console.WriteLine("I enjoy coding and building applications.");
Console.WriteLine("C# is a powerful language for developing software.");
Console.WriteLine("I look forward to mastering C# and creating amazing projects.");
Console.WriteLine("Thank you for reading my first C# program!");
// Variables declaration and Data Types
int noOfStudents = 47;
int noOfTeachers = 19;
string ourTeacherName = "Mr. Smith";
bool isSchoolOpen = true;
double averageWeightOfStudents = 55.5;
// Variable declaration about myself
string myName = "Itohowo Nkanang";
int myAge = 15;
double myHeight = 5.9;
bool isStudent = true;
char myGrade = 'A';
Console.WriteLine("Student Name: " + myName);
Console.WriteLine("Age: " + myAge);
Console.WriteLine("Height: " + myHeight + " feet");
Console.WriteLine("Is Student: " + isStudent);


// Inputs and outputs
Console.Write("Enter your username: ");
string userName = Console.ReadLine();
Console.WriteLine("Hello, " + userName );

// Ask for user's name
Console.Write("Enter your name: ");
string name = Console.ReadLine();

// Ask for first number
Console.Write("Enter the first number: ");
string firstInput = Console.ReadLine();
int firstNumber = Convert.ToInt32(firstInput);

// Ask for second number
Console.Write("Enter the second number: ");
string secondInput = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondInput);

// Calculate the sum
int sum = firstNumber + secondNumber;

// Display the result
Console.WriteLine("Hello, " + name + "! The sum of " + firstNumber + " and " + secondNumber + " is: " + sum);


// if statement
if(myAge >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

// for loop
for(int i = 1; i <= 15; i +=2)
{
    Console.WriteLine(i);
}

// function
int AddNumbers(int a, int b)
{
    return a + b;
}
Console.WriteLine(AddNumbers(100, 20));

