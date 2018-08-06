using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems.Test
{
    [TestClass]
    public class BasicProgrammingIsTrouble
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            bool aYawning = true;
            bool bYawning = true;

            //act
            bool isTrouble = BasicProgramming.IsTrouble(aYawning, bYawning);

            //assert
            Assert.AreEqual(true,isTrouble,"Both cats are yawning so we need to be in trouble which means return true");


        }

        [TestMethod]
        public void Test2()
        {
            bool aYawning = false;
            bool bYawning = false;

            //act
            bool isTrouble = BasicProgramming.IsTrouble(aYawning, bYawning);

            //assert
            Assert.AreEqual(true, isTrouble, "Both cats are not yawning so we need to be in trouble, which means return true.");
        }

        [TestMethod]
        public void Test3()
        {
            bool aYawning = true;
            bool bYawning = false;

            //act
            bool isTrouble = BasicProgramming.IsTrouble(aYawning, bYawning);

            //assert
            Assert.AreEqual(false, isTrouble, "One cat is yawning so we are not in trouble, which means return false");
        }
    }

    [TestClass]
    public class BasicProgrammingIsHooky
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            bool weekday = true;
            bool golf = true;

            //act
            bool isHooky = BasicProgramming.IsHooky(weekday, golf);

            //assert
            Assert.AreEqual(true, isHooky, "Its a weekend and we are playing golf so return true.");


        }

        [TestMethod]
        public void Test2()
        {
            bool weekday = false;
            bool golf = false;

            //act
            bool isHooky = BasicProgramming.IsHooky(weekday, golf);

            //assert
            Assert.AreEqual(true, isHooky, "Its a weekend so we are playing hooky which means true.");
        }

        [TestMethod]
        public void Test3()
        {
            bool weekday = true;
            bool golf = false;

            //act
            bool isHooky = BasicProgramming.IsHooky(weekday, golf);

            //assert
            Assert.AreEqual(false, isHooky, "Its a weekday but we are not playing golf so we return false here");
        }
    }
}
