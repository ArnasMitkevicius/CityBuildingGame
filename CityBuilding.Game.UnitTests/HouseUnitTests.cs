using CityBuildingGame.Library;
using CityBuildingGame.Library.Buildings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CityBuilding.Game.UnitTests
{
    [TestClass]
    public class HouseUnitTests
    {
        [TestMethod]
        public void UserCantBuildHouse()
        {

            var house = new House()
            {
                ID = "0",
                Title = "House",
                Level = 1,
                Pricing = new Dictionary<string, double>
                {
                    ["stone"] = 5,
                    ["bricks"] = 10
                }
            };

            var userResources = new UserResourcesContainer(
                new Dictionary<string, double>
                {
                    ["stone"] = 0,
                    ["bricks"] = 0
                }
                );

            var actual = house.CanBuild(userResources);

            Assert.AreEqual(false, actual, "User can't build a house");
        }

        [TestMethod]
        public void UserCanBuildHouse()
        {

            var house = new House()
            {
                ID = "0",
                Title = "House",
                Level = 1,
                Pricing = new Dictionary<string, double>
                {
                    ["stone"] = 5,
                    ["bricks"] = 10
                }
            };

            var userResources = new UserResourcesContainer(
                new Dictionary<string, double>
                {
                    ["stone"] = 10,
                    ["bricks"] = 10
                }
                );

            var actual = house.CanBuild(userResources);

            Assert.AreEqual(true, actual, "User can build a house");
        }

        [TestMethod]
        public void UserDoesntHaveTheseResources()
        {
            var house = new House()
            {
                ID = "0",
                Title = "House",
                Level = 1,
                Pricing = new Dictionary<string, double>
                {
                    ["stone"] = 5,
                    ["bricks"] = 10
                }
            };

            var userResources = new UserResourcesContainer(
                new Dictionary<string, double>
                {
                    ["stone"] = 10
                }
                );

            var actual = house.CanBuild(userResources);

            Assert.AreEqual(false, actual, "User can build a house");
        }

        [TestMethod]
        public void CanDowngradeHouse()
        {
            var house = new House()
            {
                ID = "0",
                Title = "House",
                Level = 1,
                Pricing = new Dictionary<string, double>
                {
                    ["stone"] = 5,
                    ["bricks"] = 10
                }
            };

            var actual = house.CanDowngrade();

            Assert.AreEqual(false, actual, "User can build a house");
        }
    }
}
