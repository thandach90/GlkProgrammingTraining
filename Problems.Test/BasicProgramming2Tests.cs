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

    [TestClass]
    public class CatMix
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "cat snacks";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "hat snacks";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "haz snacks";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "hat";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "ca";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "c";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test7()
        {
            //arrange
            string value = "";


            //act

            bool result = BasicProgramming2.CatMix(value);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class LargestCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int catA = 1;
            int catB = 2;
            int catC = 3;


            //act

            int max = BasicProgramming2.LargestCat(catA,catB,catC);

            //assert

            Assert.AreEqual(3, max);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int catA = 1;
            int catB = 3;
            int catC = 2;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(3, max);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int catA = 3;
            int catB = 2;
            int catC = 1;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(3, max);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int catA = 9;
            int catB = 3;
            int catC = 3;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int catA = 3;
            int catB = 9;
            int catC = 3;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int catA = 3;
            int catB = 3;
            int catC = 9;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int catA = 8;
            int catB = 2;
            int catC = 3;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(8, max);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int catA = -3;
            int catB = -1;
            int catC = -2;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(-1, max);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int catA = 6;
            int catB = 2;
            int catC = 5;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(6, max);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int catA = 5;
            int catB = 6;
            int catC = 2;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(6, max);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int catA = 5;
            int catB = 2;
            int catC = 6;


            //act

            int max = BasicProgramming2.LargestCat(catA, catB, catC);

            //assert

            Assert.AreEqual(6, max);
        }
    }

    [TestClass]

    public class GetClosetCatToTen
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int catA = 8;
            int catB = 13;
           


            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(8, max);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int catA = 13;
            int catB = 8;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(8, max);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int catA = 13;
            int catB = 7;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(0, max);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int catA = 7;
            int catB = 13;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(0, max);
        }
        [TestMethod]
        public void Test5()
        {
            //arrange
            int catA = 9;
            int catB = 13;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int catA = 10;
            int catB = 12;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(10, max);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int catA = 11;
            int catB = 10;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(10, max);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int catA = 5;
            int catB = 21;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(5, max);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int catA = 0;
            int catB = 20;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(0, max);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int catA = 10;
            int catB = 10;



            //act

            int max = BasicProgramming2.GetClosetCatToTen(catA, catB);

            //assert

            Assert.AreEqual(0, max);
        }
    }

    [TestClass]
    public class GetStringE
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            string value = "Hello";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            string value = "Heelle";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            string value = "Heelele";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            string value = "Hll";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            string value = "e";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            string value = "";



            //act

            bool result = BasicProgramming2.GetStringE(value);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class ThreeOr5
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int value = 3;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            int value = 10;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int value = 8;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            int value = 15;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            int value = 5;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            int value = 9;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test7()
        {
            int value = 4;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            int value = 7;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test9()
        {
            int value = 6;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test10()
        {
            int value = 17;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test11()
        {
            int value = 18;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test12()
        {
            int value = 29;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test13()
        {
            int value = 20;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test14()
        {
            int value = 21;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test15()
        {
            int value = 22;



            //act

            bool result = BasicProgramming2.ThreeOrFive(value);

            //assert

            Assert.AreEqual(false, result);
        }
    }


    [TestClass]
    public class LastDigit
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int valueA = 7;
            int valueB = 17;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA,valueB);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int valueA = 6;
            int valueB = 17;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int valueA = 3;
            int valueB = 113;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int valueA = 114;
            int valueB = 113;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int valueA = 114;
            int valueB = 4;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int valueA = 10;
            int valueB = 0;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int valueA = 11;
            int valueB = 0;


            //act

            bool result = BasicProgramming2.GetTheLastDigit(valueA, valueB);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]

    public class CreateLucky7s
    {

        [TestMethod]
        public void Test1()
        {


            //arrange
            int[] value = new int[] {7, 7, 7};


            //act

            int[] result = BasicProgramming2.CreateLucky7s();

            //assert
            CollectionAssert.AreEqual(value,result);
        }
    }

    [TestClass]
    public class SixFirstLast
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] value = new int[]{1,2,6};


        //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] value = new int[] { 6,1,2,3 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int[] value = new int[] { 13,6,1,2,3 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void Test4()
        {
            //arrange
            int[] value = new int[] { 13, 6, 1, 2, 6 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int[] value = new int[] { 3,2,1 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int[] value = new int[] { 3, 6,1 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int[] value = new int[] { 3, 6 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int[] value = new int[] { 6 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int[] value = new int[] { 3 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int[] value = new int[] { 5,6 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int[] value = new int[] { 5, 5 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test12()
        {
            //arrange
            int[] value = new int[] { 1,2,3,4,6 };


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test13()
        {
            //arrange
            int[] value = new int[] { 1, 2, 3, 4};


            //act

            bool result = BasicProgramming2.SixFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class SameFirstLast
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] value = new int[] { 1, 2, 3 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

                Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] value = new int[] { 1, 2, 3,1 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int[] value = new int[] { 1, 2, 1 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int[] value = new int[] { 7 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int[] value = new int[] {  };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int[] value = new int[] {1,2,3,4,5,1 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int[] value = new int[] { 1, 2, 3, 4, 5, 13 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int[] value = new int[] { 13, 2, 3, 4, 5, 13 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int[] value = new int[] { 7,7 };


            //act

            bool result = BasicProgramming2.SameFirstLast(value);

            //assert

            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class CatEnds
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
            int[] catsB = new int[] { 7, 3 };


            //act

            bool result = BasicProgramming2.CatEnds(catsA,catsB);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
            int[] catsB = new int[] { 7, 3,2 };


            //act

            bool result = BasicProgramming2.CatEnds(catsA, catsB);

            //assert

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
            int[] catsB = new int[] { 1,3 };


            //act

            bool result = BasicProgramming2.CatEnds(catsA, catsB);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test4()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
            int[] catsB = new int[] { 1 };


            //act

            bool result = BasicProgramming2.CatEnds(catsA, catsB);

            //assert

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test5()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
            int[] catsB = new int[] { 2 };


            //act

            bool result = BasicProgramming2.CatEnds(catsA, catsB);

            //assert

            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class CatSum3
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] catsA = new int[] { 1, 2, 3 };
           


            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] catsA = new int[] { 5,11,2 };



            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(18, result);
        }
        [TestMethod]
        public void Test3()
        {
            //arrange
            int[] catsA = new int[] { 7,0,0 };



            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int[] catsA = new int[] { 1,2,1 };



            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int[] catsA = new int[] { 1, 1, 1 };



            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Test6()
        {
            //arrange
            int[] catsA = new int[] { 2,7,2 };



            //act

            int result = BasicProgramming2.CatSum3(catsA);

            //assert

            Assert.AreEqual(11, result);
        }
    }

    [TestClass]
    public class CatsRotateLeft
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int[] input = new int[] { 1, 2, 3 };

            //act
            int[] result = BasicProgramming2.CatsRotateLeft(input);

            int[] expected = new int[]{2,3,1};

            //assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int[] input = new int[] { 5,11,9 };

            //act
            int[] result = BasicProgramming2.CatsRotateLeft(input);

            int[] expected = new int[] { 11,9,5 };

            //assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int[] input = new int[] { 7,0,0 };

            //act
            int[] result = BasicProgramming2.CatsRotateLeft(input);

            int[] expected = new int[] { 0,0,7 };

            //assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int[] input = new int[] { 1,2,1 };

            //act
            int[] result = BasicProgramming2.CatsRotateLeft(input);

            int[] expected = new int[] { 2,1,1 };

            //assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int[] input = new int[] { 0,0,1 };

            //act
            int[] result = BasicProgramming2.CatsRotateLeft(input);

            int[] expected = new int[] { 0,1,0 };

            //assert
            CollectionAssert.AreEqual(expected, result);
        }
    }


}
