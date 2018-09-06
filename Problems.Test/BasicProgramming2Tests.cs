using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems.Test
{
    [TestClass]
    public class DoesStringContainCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "candy";

            //act

            string result = BasicProgramming2.DoesStringContainCat(value);

            //assert

            Assert.AreEqual("catcandy", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "black";

            //act

            string result = BasicProgramming2.DoesStringContainCat(value);

            //assert

            Assert.AreEqual("catblack", result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "catblack";

            //act

            string result = BasicProgramming2.DoesStringContainCat(value);

            //assert

            Assert.AreEqual("catblack", result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "cat";

            //act

            string result = BasicProgramming2.DoesStringContainCat(value);

            //assert

            Assert.AreEqual("cat", result);
        }

        public void Test5()
        {
            //arrange
            string value = "iscat";

            //act

            string result = BasicProgramming2.DoesStringContainCat(value);

            //assert

            Assert.AreEqual("catiscat", result);
        }
    }

    [TestClass]
    public class CatSubString
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "candy";

            //act

            string result = BasicProgramming2.CatSubString(value);

            //assert

            Assert.AreEqual("c", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "black";

            //act

            string result = BasicProgramming2.CatSubString(value);

            //assert

            Assert.AreEqual("b", result);
        }
    }

    [TestClass]
    public class CatString
    {

        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "black";

            //act

            string result = BasicProgramming2.CatString(value);

            //assert

            Assert.AreEqual("catblack", result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "orange";

            //act

            string result = BasicProgramming2.CatString(value);

            //assert

            Assert.AreEqual("catorange", result);
        }
    }

    [TestClass]

    public class CatIsMissingSomething
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "cat";

            //act

            string result = BasicProgramming2.CatIsMissingSomething(value,1);

            //assert

            Assert.AreEqual("ct", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "black";

            //act

            string result = BasicProgramming2.CatIsMissingSomething(value, 2);

            //assert

            Assert.AreEqual("blck", result);
        }
    }


    [TestClass]
    public class SwappedCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "code";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("eodc", result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "a";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("a", result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "ab";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("ba", result);
        }
        [TestMethod]
        public void Test4()
        {
            //arrange
            string test = "abc";

            //act

            string result = BasicProgramming2.SwappedCat(test);

            //assert

            Assert.AreEqual("cba", result);
        }
        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "Chocolate";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("ehocolatC", result);
        }
        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "aavJ";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("Java", result);
        }
        [TestMethod]
        public void Test8()
        {
            //arrange
            string value = "hello";

            //act

            string result = BasicProgramming2.SwappedCat(value);

            //assert

            Assert.AreEqual("oellh", result);
        }


    }

    [TestClass]
    public class HowLongIsCat
    {
        [TestMethod]
        public void Test1()
        {
           
        }
    }
}
