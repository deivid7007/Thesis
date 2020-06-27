using System;

namespace MyNumberDiapason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000)
            {
                Console.WriteLine($"The number {number} is less than 1000!");
            }
            else if (number > 1000 && number < 10000)
            {
                Console.WriteLine($"The number {number} is between 1000 and 10000!");
            }
            else
            {
                Console.WriteLine($"The number {number} is greater than 10000!");
            }
        }
    }
}
