using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library
{
    public abstract class Resource
    {
        public string Title { get; set; }
        public double Quantity { get; set; }
    }
}
