using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void gasTankLevelTest()
        {
            Car test1 = new Car("Honda", "Civic", 12, 39.0);

            test1.Drive(50);
            Assert.AreEqual(10.75, test1.GasTankLevel, .1);
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(1, 1, .001);
        }



        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            Car test2 = new Car("Honda", "Civic", 12, 39.0);
            test2.Drive(500);
            Assert.IsTrue((test2.GasTankLevel * 39) < 500);
        }


        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            Car test3 = new Car("Honda", "Civic", 12, 39.0);
            test3.AddGas(14);
            Assert.Fail("Cannot put more gas than gas tank level.");




        }



    }
}
