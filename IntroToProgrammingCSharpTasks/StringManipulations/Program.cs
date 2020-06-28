using System;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, I am Deivid Mladenov and I appreciate your attention!";
            Console.WriteLine($"Starting text ---> {text}");
            Console.WriteLine($"To lower ---> {text.ToLower()}");
            Console.WriteLine($"To upper ---> {text.ToUpper()}");
            Console.WriteLine($"IndexOf Deivid ---> {text.IndexOf("Deivid")}");
            Console.WriteLine($"Replace attention with work ---> {text.Replace("attention", "work")}");
        }
    }
}
