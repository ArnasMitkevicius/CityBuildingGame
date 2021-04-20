using CityBuildingGame.Library;
using CityBuildingGame.Library.Buildings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CityBuilding.Game.UnitTests
{
    [TestClass]
    public class CityUnitTests
    {
        [TestMethod]
        public void UserCantBuildBuilding()
        {
            City city = new City();
            city.SetBuilding("House", 1);
            int spot = 1;

            var actual = city.canBuild(spot);

            Assert.AreEqual(false, actual, "User can't build a building");
        }

        [TestMethod]
        public void UserCanBuildBuilding()
        {

            City city = new City();
            city.SetBuilding("House", 1);
            int spot = 2;

            var actual = city.canBuild(spot);

            Assert.AreEqual(true, actual, "User can build a house");
        }

        [TestMethod]
        public void UserCanDestroy()
        {
            City city = new City();
            city.SetBuilding("House", 1);
            int spot = 1;

            var actual = city.canDestroy(spot);

            Assert.AreEqual(true, actual, "User can destroy a building");
        }

    }
}
