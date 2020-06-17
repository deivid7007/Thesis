using System;

namespace NumbersInDifferentNumeralSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 555;

            string binary = Convert.ToString(number, 2);
            string ocataldecimal = Convert.ToString(number, 8);
            string hexadecimal = Convert.ToString(number, 16);

            Console.WriteLine($"The number 555 in binary is {binary}");
            Console.WriteLine($"The number 555 in ocataldecimal is {ocataldecimal}");
            Console.WriteLine($"The number 555 in hexadecimal is {hexadecimal}");
        }
    }
}
