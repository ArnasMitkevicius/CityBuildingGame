using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityBuildingGame.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildingGame.Library.Tests
{
    [TestClass()]
    public class CityTests
    {
        [TestMethod()]
        public void houseCanBeBuild()
        {
            City city= new City();
            int spot = 1;
            bool expected = false;


            // Preparation
            city.SetBuilding("House", spot);
            bool var = city.canBuild(spot);

            Assert.AreEqual(expected, var);
        }

        [TestMethod()]
        public void houseCantBeBuild()
        {
            City city = new City();
            int spot = 1;
            bool expected = true;


            // Preparation
           
            bool var = city.canBuild(spot);

            Assert.AreEqual(expected, var);
        }

        [TestMethod()]
        public void buildingCanBeDestroyed()
        {
            City city = new City();
            int spot = 1;
            bool expected = true;

            // Preparation

            city.SetBuilding("House", spot);
            bool var = city.canDestroy(spot);

            Assert.AreEqual(expected, var);
        }

        [TestMethod()]
        public void buildingCantBeDestroyed()
        {
            City city = new City();
            int spot = 1;
            bool expected = false;

            bool var = city.canDestroy(spot);

            Assert.AreEqual(expected, var);
        }

    }
}


/*
 
 TestClass]
    class KitUnitTest
    {
        [TestMethod]
        public void BuildingCanBeBuild()
        {
            // arrange

            City city = new City();
            int spot = 1;
            bool expected = false;
            // action


            city.SetBuilding("House", spot);
            bool var = city.canBuild(spot);

            // assert

            Assert.AreEqual(expected, var);
        }
    }
 */
