using System;

namespace RainingStations
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a station:\n" +
                "1 --> Sofia station\n" +
                "2 --> Plovdiv station\n" +
                "3 --> Burgas station");

            bool optionIsNumber = false;
            int option = 0;

            while (!optionIsNumber)
            {
                Console.Write("Enter your option here: ");
                optionIsNumber = int.TryParse(Console.ReadLine(), out option);
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("----------------\n" +
                        "Sofia Staion\n" +
                        "----------------");

                    int[] sofiaArray = new int[12];

                    InputArray(sofiaArray);
                    OutputArray(sofiaArray);

                    double averageRainInSofia = AverageAmountOfRainingForAYear(sofiaArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInSofia);

                    PrintMonthsWithFilter(sofiaArray);

                    break;
                case 2:
                    Console.WriteLine("----------------\n" +
                        "Plovdiv Staion\n" +
                        "----------------");

                    int[] plovdivArray = new int[12];
                    InputArray(plovdivArray);
                    OutputArray(plovdivArray);
                    double averageRainInPlovdiv = AverageAmountOfRainingForAYear(plovdivArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInPlovdiv);
                    PrintMonthsWithFilter(plovdivArray);

                    break;
                case 3:
                    Console.WriteLine("----------------\n" +
                        "Burgas Staion\n" +
                        "----------------");

                    int[] burgasArray = new int[12];
                    InputArray(burgasArray);
                    OutputArray(burgasArray);
                    double averageRainInBurgas = AverageAmountOfRainingForAYear(burgasArray);
                    Console.WriteLine("The average amount of rain for a year in this station is: {0:F2} mm/m2",
                        averageRainInBurgas);
                    PrintMonthsWithFilter(burgasArray);

                    break;
                default:
                    Console.WriteLine("Incorrect number of station!");
                    break;
            }
        }

        static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 201);
            }
        }

        static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Raining in month " + (i + 1) + ": " + arr[i] + " mm/m2");
            }
        }

        static double AverageAmountOfRainingForAYear(int[] arr)
        {
            double totalAmountOfRainForAYear = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                totalAmountOfRainForAYear += arr[i];
            }

            return totalAmountOfRainForAYear / arr.Length;
        }

        static void PrintMonthsWithFilter(int[] arr)
        {
            bool thereAreMonths = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 76 && arr[i] % 7 == 0)
                {
                    thereAreMonths = true;
                    Console.WriteLine("Month " + (i + 1) + " has amount of rain more than 76 mm/m2 and that amount can be divided by 7 without remainder.");
                    break;
                }
            }

            if (!thereAreMonths)
            {
                Console.WriteLine("There aren't any months with rain more than 76 mm/m2, which can be divided by 7 without remainder.");
            }
        }
    }
}
