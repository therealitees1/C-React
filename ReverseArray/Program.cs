using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] reversed = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }

        foreach (int num in reversed)
        {
            Console.Write(num + " ");
        }
    }
}
