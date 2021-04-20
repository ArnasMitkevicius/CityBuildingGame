using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library
{
    public class UserResourcesContainer
    {
        Dictionary<string, double> Resources { get; set; }

        public UserResourcesContainer()
        {
            Resources = new Dictionary<string, double>();
            Resources.Add("Wheat", 50);
            Resources.Add("Wood", 50);
            Resources.Add("Stone", 50);
        }

        public UserResourcesContainer(Dictionary<string, double> resources)
        {
            Resources = resources;
        }

        public Dictionary<string, double> getResource()
        {
            return Resources;
        }

        public void SetResources(Dictionary<string, double> resources)
        {
            Resources = resources;
        }

        public void AddResource(string resourceID, double quantity)
        {
            Resources[resourceID] += quantity;
        }

        public void RemoveResource(string resourceID, double quantity)
        {
            Resources[resourceID] -= quantity;
        }

        public bool HasUserEnoughtResources(string resourceID, double quantity)
        {
            return Resources[resourceID] >= quantity;
        }
    }
}
