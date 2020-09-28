using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatoriske_opgave_1;

namespace FanOutput_Test
{
    [TestClass]
    public class FanOutTest
    {
        [TestMethod]
        public void TestNameLength()
        {
            try
            {
                FanOutput output = new FanOutput() { Name = "t" };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Name must be atleast 2 Charactes long", e.Message);
            }

        }

        [TestMethod]
        public void TestTempLower()
        {
            try
            {
                FanOutput output = new FanOutput() { Temp = 14 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("temperaturen er for lav, skal være over 15 grader", e.Message);
            }
        }

        [TestMethod]
        public void TestTempHigher()
        {
            try
            {
                FanOutput output = new FanOutput() { Temp = 26 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("temperaturen er for høj, skal være under 25 grader", e.Message);
            }
        }

        [TestMethod]
        public void TestFugtLav()
        {
            try
            {
                FanOutput output = new FanOutput() { Fugt = 22 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("fugten er for lav", e.Message);
            }
        }

        [TestMethod]
        public void TestFugtHigh()
        {
            try
            {
                FanOutput output = new FanOutput() { Fugt = 85 };
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("fugten er for høj", e.Message);
            }
        }

        [TestMethod]
        public void GetNameTest()
        {
            try
            {
                FanOutput output = new FanOutput() { Name = "Test er fin" };

                Assert.AreEqual("Test er fin", output.Name);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetIdTest()
        {
            try
            {
                FanOutput output = new FanOutput() { Id = 1 };
                Assert.AreEqual(1, output.Id);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetTempTest()
        {
            try
            {
                FanOutput output = new FanOutput() { Temp = 20 };
                Assert.AreEqual(20, output.Temp);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetFugtTest()
        {
            try
            {
                FanOutput output = new FanOutput() { Fugt = 40 };
                Assert.AreEqual(40, output.Fugt);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}
