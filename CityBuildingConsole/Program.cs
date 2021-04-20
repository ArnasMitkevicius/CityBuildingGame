using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CityBuildingGame.Library;

namespace CityBuildingConsole
{
    public class Program
    {
        City city;
        People people;
        UserResourcesContainer resources;
        Dictionary<string, double> resource;

        public Program()
        {
            city = new City();
            people = new People();
            resources = new UserResourcesContainer();
            resource = new Dictionary<string, double>();
        }

        public void runProgram()
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Your population: " + people.getTotal());

                Console.Write("Your resources: ");
                /* for (int i = 0; i < resources.; i++)
                 {
                     Console.Write(resource[] + " ");
                 }*/
                Console.WriteLine();

                Console.WriteLine("Your buildings: ");
                for (int i = 0; i < city.getSize(); i++)
                {
                    Console.Write(city.GetBuilding(i) + " ");
                }
                Console.WriteLine("\n");

                //input
                Console.WriteLine("1 Build a new building." +
                    "\n2 Destroy building." +
                    "\n3 Upgrade building." +
                    "\n4 Downgrade building." +
                    "\n5 Exit");
                string input = Console.ReadLine();

            }
        }
    }
}
