using System;

namespace TravelingToTheSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const double speedOfSound = 1225.044; // in km/h
            const long distToSun = 149600000; // in km
            double timeNeeded = Math.Round(distToSun / speedOfSound); // in hours
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double leftoverDays = Math.Floor(((timeNeeded / 8760) - timeNeededInYears) * 365);

            Console.WriteLine($"The time needed to travel from the Earth to the Sun is {timeNeeded} hours, or " +
                $"{timeNeededInYears} years and {leftoverDays} days.");
        }
    }
}
