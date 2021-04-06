using System;
using System.Collections.Generic;
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
        }

        public UserResourcesContainer(Dictionary<string, double> resources)
        {
            Resources = resources;
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
