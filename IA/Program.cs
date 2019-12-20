using System;
using System.Linq;
using SWAPI;
using SWAPI.Extensions;

namespace IntergalacticAirways
{
    public class Program
    {
        // This program asks for number of passengers as input
        // and returns all ships and all pilots of said ships
        // that both exist in the Star Wars API (swapi.co) and
        // can carry that number of passengers
        static void Main(string[] args)
        {
            Console.Write("Enter number of passengers: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int passengers))
            {
                var swApiClient = new SWAPIClient();
                var ships = swApiClient.GetAllStarshipAsync().Result;
                foreach (var ship in ships)
                {
                    if (long.TryParse(ship.passengers, out long shipPassengers))
                    {
                        if (passengers <= shipPassengers)
                        {
                            var pilots = ship.GetPilotAsync(swApiClient).Result;
                            if (pilots.Count() == 0)
                            {
                                Console.WriteLine($"{ship.name} - No pilots listed");
                                continue;
                            }

                            foreach (var pilot in pilots)
                            {
                                Console.WriteLine($"{ship.name} - {pilot.name}");
                            }
                        }
                    }
                }
            }
        }
    }
}
