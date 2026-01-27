using System;
class Program
{
    static void Main()
    {
        string name = "Itohowo Nkanang";
        Console.WriteLine("Original Name:" + name);

        Console.WriteLine("Uppercase Name:" + name.ToUpper());
        Console.WriteLine("Lowercase Name:" + name.ToLower());
        Console.WriteLine(name.Length);

        string newName = name.Replace("Itohowo", "John");
        Console.WriteLine("Changed Name Name:" + newName);

        string[] seperatedName = name.Split(' ');
        Console.WriteLine("First Name:" + seperatedName[0]);
        Console.WriteLine("Last Name:" + seperatedName[1]);

             Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        if (!string.IsNullOrEmpty(email) && email.Contains("@"))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.ReadLine();
    }
}
