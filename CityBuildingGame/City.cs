using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library
{
    class City
    {

        string[] cityArray;
        public City()
        {
            cityArray = new string[10];
            for (int i=0;i<cityArray.Length;i++)
            {
                cityArray[i] = "-";
            }
        }

        public string[] GetCity()
        {
        return cityArray;
        }

        public string GetBuilding(int spot)
        {
            return cityArray[spot];
        }

        public void SetCity(string[] city)
        {
            cityArray = city;
        }

        public void SetBuilding(string Building, int spot)
        {
            cityArray[spot] = Building;
        }

        public bool canBuild(int spot)
        {
            if (Convert.ToString(spot) == "-")
            {
                return true;
            }
            else return false;
        }

    }
}
