using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library
{
    public class People
    {
        public int Total;
        public int Unavailable;

        public People()
        {
            Total = 10;
            Unavailable = 0;
        }

        public int getTotal()
        {
            return Total;
        }
    }
}
