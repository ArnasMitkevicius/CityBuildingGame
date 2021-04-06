using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library.Buildings
{
    public class House : Building
    {
        public override bool CanBuild(UserResourcesContainer userResourcesContainer)
        {
            foreach(var value in Pricing)
            {
                if (!userResourcesContainer.HasUserEnoughtResources(value.Key, value.Value)) return false;
            }

            return true;

            
        }
    }
}
