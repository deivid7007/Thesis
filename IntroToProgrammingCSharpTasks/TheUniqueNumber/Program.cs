using System;

namespace TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageAfter10Years = 0;
            Console.WriteLine("How old are you?");
            ageAfter10Years = int.Parse(Console.ReadLine()) + 10;
            Console.WriteLine("Which is your birth year?");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Which is your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());
            double uniqueNumber = (ageAfter10Years * birthYear) / Math.PI * birthMonth;
            Console.WriteLine($"Your unique number is {Math.Round(uniqueNumber, 4)}!");
        }
    }
}
