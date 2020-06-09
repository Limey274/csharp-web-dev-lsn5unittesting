using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    public class CarTests
    {
        // TODO: add emptyTest so we can configure our runtime environment(remove this test before pushing to your personal GitHub account)
        [TestClass]
        public class Cartests
        {
            [TestMethod]
            public void EmptyTest()
            {
                Assert.AreEqual(10, 10, .001);
            }


            //Initalize 
            Car test_car;

            [TestInitialize]
            public void CreateCarObject()
            {
                test_car = new Car("Toyota", "Prius", 10, 50);
            }


            //TODO: constructor sets gasTankLevel properly
            [TestMethod]
            public void TestInitialGas()
            {
                Assert.AreEqual(10, test_car.GasTankLevel, .001);
            }


            //TODO: gasTankLevel is accurate after driving within tank range
            [TestMethod]
            public void TestGasAfterDriving()
            {
                test_car.Drive(50);
                Assert.AreEqual(9, test_car.GasTankLevel, .001);
            }


            //TODO: gasTankLevel is accurate after attempting to drive past tank range
            [TestMethod]
            public void OutOfGas()
            {
                test_car.Drive(10000);
                Assert.IsTrue(0 == test_car.GasTankLevel, "You drove to far and are out of gas. ");
            }

            //TODO: can't have more gas than tank size, expect an exception
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestGasOverfillException()
            {
                test_car.AddGas(5);
                Assert.Fail("Dont overfill the tank");
            }

        }
    }

}