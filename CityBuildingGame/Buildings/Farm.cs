using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library.Buildings
{
    public class Farm : Building
    {
        public override bool CanBuild(UserResourcesContainer userResourcesContainer)
        {
            return UserHasEnoughtMoney(userResourcesContainer);
        }
    }
}
