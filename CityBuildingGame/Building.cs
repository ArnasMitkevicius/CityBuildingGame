﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library
{
    public abstract class Building
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        public Dictionary<string, double> Pricing { get; set; }

        public abstract bool CanBuild(UserResourcesContainer userResourcesContainer);

        public bool UserHasEnoughtMoney(UserResourcesContainer userResourcesContainer)
        {
            foreach (var value in Pricing)
            {
                if (!userResourcesContainer.HasUserEnoughtResources(value.Key, value.Value)) return false;
            }

            return true;
        }

        public bool CanDowngrade()
        {
            return true;
        }
    }
}
