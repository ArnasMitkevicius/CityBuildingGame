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

        public int chooseSpot()
        {
            Console.WriteLine("In which spot? (1-10): ");
            int spot = int.Parse(Console.ReadLine());
            spot--;
            return spot;
        }


        public void chooseBuilding()
        {
            Console.WriteLine("1. Mine. " + "\n2. Farm. " + "\n3. House " + "\n4. LumberWorkshop.");
            string input = Console.ReadLine();
            int spot;
            switch (input)
            {
                case "1":
                    spot = chooseSpot();
                    if(city.canBuild(spot)) city.SetBuilding("Mine", spot);
                    break;
                case "2":
                    spot = chooseSpot();
                    if(city.canBuild(spot)) city.SetBuilding("Farm", spot);
                    break;
                case "3":
                    spot = chooseSpot();
                    if (city.canBuild(spot)) city.SetBuilding("House", spot);
                    break;
                case "4":
                    spot = chooseSpot();
                    if (city.canBuild(spot)) city.SetBuilding("LumberWorkshop", spot);
                    break;
            }
        }

        public void destroyBuilding()
        {
            Console.WriteLine("Building on which spot to destroy? (1-10): ");
            int input = int.Parse(Console.ReadLine());
            input--;
            if (city.canDestroy(input)) city.DestroyBuilding(input);
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


                switch (input)
                {
                    case "1":
                        chooseBuilding();
                        break;
                    case "2":
                        destroyBuilding();
                        break;
                    default:
                        Console.WriteLine("Unknow input");
                        break;
                }

            }
        }
    }
}
