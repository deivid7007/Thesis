using System;

namespace NumberComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}!");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}!");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is less than {secondNumber}!");
            }
        }
    }
}
