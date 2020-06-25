using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You will be {age+10} years old after 10 years!");
        }
    }
}
