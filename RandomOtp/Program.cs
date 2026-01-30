using System;

class Program
{
    static void Main()
    {
        // Length of the OTP (change as desired)
        int otpLength = 6;

        // Generate OTP
        string otp = GenerateNumericOtp(otpLength);
        Console.WriteLine($"Generated OTP: {otp}");

        // Example: prompt user to enter OTP to validate
        Console.Write("Enter the OTP: ");
        string input = Console.ReadLine();

        if (input == otp)
            Console.WriteLine("OTP is correct!");
        else
            Console.WriteLine("OTP is incorrect.");
    }
         // Generates a numeric OTP of the requested length
    static string GenerateNumericOtp(int length)
    {
        if (length <= 0) return "";

        var rng = new Random();
        char[] digits = new char[length];

        for (int i = 0; i < length; i++)
        {
            digits[i] = (char)('0' + rng.Next(0, 10)); // random digit 0-9
        }
             return new string(digits);
        }
    }