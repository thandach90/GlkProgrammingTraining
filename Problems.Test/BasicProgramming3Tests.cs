using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems.Test
{
    [TestClass]
    public class EveryOther
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string value = "Miracle";
            int num = 2;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("Mrce", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string value = "abcdefg";
            int num = 2;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("aceg", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string value = "abcdefg";
            int num = 3;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("adg", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string value = "Chocolate";
            int num = 3;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("Cca", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string value = "Chocolates";
            int num = 3;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("Ccas", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string value = "Chocolates";
            int num = 4;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("Coe", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string value = "Chocolates";
            int num = 100;

            //act

            string result = BasicProgramming3.EveryOther(value, num);

            //assert

            Assert.AreEqual("C", result);
        }
    }

    [TestClass]

    public class StringTimesItSelf
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string value = "Hi";
            int num = 2;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("HiHi", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string value = "Hi";
            int num = 3;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("HiHiHi", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string value = "Hi";
            int num = 1;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("Hi", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string value = "Hi";
            int num = 0;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string value = "Hi";
            int num = 5;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("HiHiHiHiHi", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string value = "Oh Boy!";
            int num = 2;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("Oh Boy!Oh Boy!", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string value = "x";
            int num = 4;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("xxxx", result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string value = "";
            int num = 4;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string value = "code";
            int num = 4;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("codecode", result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string value = "code";
            int num = 4;

            //act

            string result = BasicProgramming3.StringTimesItSelf(value, num);

            //assert

            Assert.AreEqual("codecodecode", result);
        }

    }

    [TestClass]
    public class DoubleC
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string value = "accbb";
           

            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string value = "acacac";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string value = "ccccc";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string value = "caccc";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string value = "aaaac";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string value = "";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string value = "abc";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string value = "c";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string value = "cc";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string value = "cac";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            //arrange
            string value = "cacc";


            //act

            bool result = BasicProgramming3.DoubleC(value);

            //assert

            Assert.AreEqual(false, result);
        }

    }

    [TestClass]
    public class MissingMiddle
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string value = "Hello";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("Hlo", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string value = "Hi";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("H", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string value = "Heeololeo";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("Hello", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string value = "HiHiHi";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("HHH", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string value = "";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string value = "Greetings";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("Getns", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string value = "Chocoate";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("Coot", result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string value = "pi";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("p", result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string value = "Hello Kitten";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("HloKte", result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string value = "hxaxpxpxy";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("happy", result);
        }
    }

    [TestClass]
    public class StringPlosion
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string value = "Code";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("CCoCodCode", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string value = "abc";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("aababc", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string value = "ab";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("aab", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string value = "x";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("x", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string value = "fade";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("ffafadfade", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string value = "There";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("TThTheTherThere", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string value = "Kitten";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("KKiKitKittKitteKitten", result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string value = "Bye";


            //act

            string result = BasicProgramming3.MissingMiddle(value);

            //assert

            Assert.AreEqual("BByBye", result);
        }
    }
}
