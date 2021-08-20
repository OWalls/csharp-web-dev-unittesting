using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        //TODO: constructor sets gasTankLevel properly
        Car toyota;

        [TestInitialize]
        public void InitializeCar()
        {
            toyota = new Car("Toyota", "Prius", 10, 50);
        }
        

        [TestMethod]
        public void InitialGasTankLevelTest()
        {
            
            Assert.AreEqual(10, toyota.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]

        public void GasTankAccurateTest()
        {
            toyota.Drive(50);
            Assert.AreEqual(9, toyota.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void GasTankAccurateAfterExceedingRange()
        {
            //500 is maxMileage;
            //450 miles left after previous test, 9*50, would have 0 left
            toyota.Drive(600);
            Assert.AreEqual(0, toyota.GasTankLevel);

        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            toyota.AddGas(20);
            Assert.Fail("Can't exceed tank size");
        }

    }



}
