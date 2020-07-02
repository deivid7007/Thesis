using System;
using System.Text;

namespace JupiterPancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool inputIsCorrect = false;
            bool weightIsCorrect = false;

            string userInput;
            string astronautName = "";

            int weight = 0;

            while (!inputIsCorrect || !weightIsCorrect)
            {
                Console.WriteLine("Enter your name and your weight (separate them with a space):");
                userInput = Console.ReadLine();

                if (!userInput.Contains(" "))
                {
                    Console.WriteLine("Incorrect data!");
                    continue;
                }
                else
                {
                    inputIsCorrect = true;
                }

                astronautName = userInput.Substring(0, userInput.IndexOf(" "));
                weightIsCorrect = int.TryParse(userInput.Substring(userInput.IndexOf(" ")), out weight);
            }

            int fallHeight = CalculateHeight(astronautName);
            double energy = EnergyAtImpact(weight, fallHeight);

            Console.WriteLine("Energy at impact: " + energy + " joules");

            if (energy < 1500000)
            {
                Console.WriteLine("The candidate is approved!");
            }
            else
            {
                Console.WriteLine("The candidate is a \"Jupiter pancake\"!"); // Here we use character escaping by using the \ symbol
            }
        }

        static int CalculateHeight(string name)
        {
            int charSum = 0;

            foreach (char c in name)
            {
                charSum += c;
            }

            return charSum;
        }

        static double EnergyAtImpact(int mass, int height)
        {
            const double jupiterGravity = 24.79;

            return mass * jupiterGravity * height;
        }
    }
}
