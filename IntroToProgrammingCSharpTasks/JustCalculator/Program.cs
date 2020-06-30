using System;

namespace JustCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please select action (+, -, *, /)");
                char action = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case '+':
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case '-':
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case '*':
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case '/':
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;
                    default:
                        Console.WriteLine("Incorrect action!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The program throwed exception with message: {ex.Message}");
            }
        }
    }
}
