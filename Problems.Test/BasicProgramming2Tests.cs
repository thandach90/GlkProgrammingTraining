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

    public class FirstThree
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "Java";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("JavJavJav", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "Chocolate";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("ChoChoCho", result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "abc";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("abcabcabc", result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "abcXYZ";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("abcabcabc", result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "ab";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("ababab", result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "a";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("aaa", result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "";

            //act

            string result = BasicProgramming2.FirstThree(value);

            //assert

            Assert.AreEqual("", result);
        }
    }

    [TestClass]
    public class BringItBack
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "cat";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("tcatt", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "Hello";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("oHelloo", result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "a";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("aaa", result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "abc";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("cabcc", result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "read";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("dreadd", result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "boo";

            //act

            string result = BasicProgramming2.BringItBack(value);

            //assert

            Assert.AreEqual("obooo", result);
        }
    }

    [TestClass]

    public class BringItBackTwice
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "kitten";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("kikittenki", result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "Ha";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("HaHaHa", result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "abc";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("ababcab", result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "ab";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("ababab", result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "a";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("aaa", result);
        }
        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "Logic";

            //act

            string result = BasicProgramming2.BringItBackTwice(value);

            //assert

            Assert.AreEqual("LoLogicLo", result);
        }

    }

    [TestClass]
    public class StartWithCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "cat there";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "cat";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "hello cat";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "ca";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "c";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "ho cat";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            string value = "cat ho";

            //act

            bool result = BasicProgramming2.StartWithCat(value);

            //assert

            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class ZeroToHundered
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int num1 = 120;
            int num2 = -1;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1,num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int num1 = -1;
            int num2 = 120;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int num1 = 2;
            int num2 = 120;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1, num2);

            //assert

            //Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int num1 = -1;
            int num2 = 100;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int num1 = -2;
            int num2 = -2;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int num1 = 120;
            int num2 = 120;

            //act

            bool result = BasicProgramming2.ZeroToHundered(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class CaughtBetween10And20
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int num1 = 12;
            int num2 = 99;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int num1 = 21;
            int num2 = 12;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int num1 = 8;
            int num2 = 99;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int num1 = 99;
            int num2 = 10;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int num1 = 20;
            int num2 = 20;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int num1 = 21;
            int num2 = 21;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int num1 = 9;
            int num2 = 9;

            //act

            bool result = BasicProgramming2.CaughtBetween10And20(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]

    public class IsItACatOrKitten
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int num1 = 13;
            int num2 = 20;
            int num3 = 10;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2,num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int num1 = 20;
            int num2 = 19;
            int num3 = 10;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int num1 = 20;
            int num2 = 10;
            int num3 = 13;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int num1 = 1;
            int num2 = 20;
            int num3 = 12;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int num1 = 19;
            int num2 = 20;
            int num3 = 12;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int num1 = 12;
            int num2 = 20;
            int num3 = 19;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int num1 = 12;
            int num2 = 9;
            int num3 = 20;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int num1 = 12;
            int num2 = 18;
            int num3 = 20;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int num1 = 14;
            int num2 = 2;
            int num3 = 20;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int num1 = 4;
            int num2 = 2;
            int num3 = 20;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int num1 = 11;
            int num2 = 22;
            int num3 = 22;

            //act

            bool result = BasicProgramming2.IsItACatOrKitten(num1, num2, num3);

            //assert

            Assert.AreEqual(false, result);
        }
    }


    [TestClass]
    public class IsOneAKitten
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int num1 = 13;
            int num2 = 99;
           

            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int num1 = 21;
            int num2 = 19;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int num1 = 13;
            int num2 = 13;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int num1 = 14;
            int num2 = 20;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int num1 = 20;
            int num2 = 15;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int num1 = 16;
            int num2 = 17;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int num1 = 16;
            int num2 = 9;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int num1 = 16;
            int num2 = 18;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int num1 = 13;
            int num2 = 19;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int num1 = 13;
            int num2 = 20;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int num1 = 6;
            int num2 = 18;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test12()
        {
            //arrange
            int num1 = 99;
            int num2 = 13;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test13()
        {
            //arrange
            int num1 = 99;
            int num2 = 99;


            //act

            bool result = BasicProgramming2.IsOneAKitten(num1, num2);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class DeleteCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "acatbc";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

        Assert.AreEqual("abc", result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "acatHello";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("aHello", result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "adedbc";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("adedbc", result);
        }
        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "abccat";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("abccat", result);
        }
        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "add";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("add", result);
        }
        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "ad";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("ad", result);
        }
        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "a";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("a", result);
        }
        [TestMethod]
        public void Test8()
        {
            //arrange
            string value = "";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void Test9()
        {
            //arrange
            string value = "cat";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("cat", result);
        }
        [TestMethod]
        public void Test10()
        {
            //arrange
            string value = "acat";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("a", result);
        }
        [TestMethod]
        public void Test11()
        {
            //arrange
            string value = "aacatbb";


            //act

            string result = BasicProgramming2.DeleteCat(value);

            //assert

            Assert.AreEqual("aacatbb", result);
        }
    }


}
