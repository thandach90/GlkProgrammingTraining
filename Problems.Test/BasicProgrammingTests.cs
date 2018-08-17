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
            Assert.AreEqual(true, isTrouble, "Both cats are yawning so we need to be in trouble which means return true");
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

    [TestClass]
    public class BasicProgrammingDoubleSum
    {
        [TestMethod]
        public void Test1()
        {
            int first = 1;
            int second = 2;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        public void Test2()
        {
            int first = 3;
            int second = 2;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(5, sum);
        }

        [TestMethod]
        public void Test3()
        {
            int first = 2;
            int second = 2;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(8, sum);
        }

        [TestMethod]
        public void Test4()
        {
            int first = -1;
            int second = 0;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(-1, sum);
        }

        [TestMethod]
        public void Test5()
        {
            int first = 3;
            int second = 3;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(12, sum);
        }

        [TestMethod]
        public void Test6()
        {
            int first = 0;
            int second = 0;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void Test7()
        {
            int first = 0;
            int second = 1;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void Test8()
        {
            int first = 3;
            int second = 4;

            //act
            int sum = BasicProgramming.DoubleSum(first, second);

            //assert
            Assert.AreEqual(7, sum);
        }
    }

    [TestClass]
    public class BasicProgrammingDifferenceOf21
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int input = 19;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test2()
        {
            int input = 10;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void Test3()
        {
            int input = 21;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test4()
        {
            int input = 22;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test5()
        {
            int input = 25;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Test6()
        {
            int input = 30;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Test7()
        {
            int input = 0;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Test8()
        {
            int input = 1;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test9()
        {
            int input = 2;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Test10()
        {
            int input = -1;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void Test11()
        {
            int input = -2;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Test12()
        {
            int input = 50;

            //act
            int result = BasicProgramming.DifferenceOf21(input);

            //assert
            Assert.AreEqual(58, result);
        }
    }

    [TestClass]
    public class BasicProgrammingCatMakesUsAngry
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            bool meowing = true;
            int hour = 6;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            bool meowing = true;
            int hour = 7;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            bool meowing = false;
            int hour = 6;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            bool meowing = true;
            int hour = 21;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            bool meowing = false;
            int hour = 21;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            bool meowing = false;
            int hour = 20;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            bool meowing = true;
            int hour = 23;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            bool meowing = false;
            int hour = 23;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            bool meowing = true;
            int hour = 20;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            bool meowing = false;
            int hour = 12;

            //act
            bool result = BasicProgramming.CatMakesUsAngry(meowing, hour);

            //assert
            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class BasicProgrammingTenYearOldCat
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int catA = 9;
            int catB = 10;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int catA = 9;
            int catB = 9;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int catA = 1;
            int catB = 9;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int catA = 10;
            int catB = 1;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int catA = 10;
            int catB = 10;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int catA = 8;
            int catB = 2;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int catA = 8;
            int catB = 3;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int catA = 10;
            int catB = 42;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int catA = 12;
            int catB = -2;

            //act
            bool result = BasicProgramming.TenYearOldCat(catA, catB);

            //assert
            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class BasicProgrammingIsCatClose
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int feet = 93;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int feet = 90;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int feet = 89;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int feet = 110;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int feet = 111;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int feet = 121;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int feet = -101;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int feet = -209;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int feet = 190;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int feet = 209;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int feet = 0;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test12()
        {
            //arrange
            int feet = 5;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test13()
        {
            //arrange
            int feet = -50;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test14()
        {
            //arrange
            int feet = 191;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test15()
        {
            //arrange
            int feet = 189;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test16()
        {
            //arrange
            int feet = 200;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test17()
        {
            //arrange
            int feet = 210;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test18()
        {
            //arrange
            int feet = 211;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test19()
        {
            //arrange
            int feet = 290;

            //act
            bool result = BasicProgramming.IsCatClose(feet);

            //assert
            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class BasicProgrammingPositiveNegative
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int a = 1;
            int b = -1;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a,b,neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int a = -1;
            int b = 1;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int a = -4;
            int b = -5;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int a = -4;
            int b = -5;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int a = -4;
            int b =  5;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int a = -4;
            int b = 5;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int a = 1;
            int b = 1;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test8()
        {
            //arrange
            int a = -1;
            int b = -1;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test9()
        {
            //arrange
            int a =  1;
            int b = -1;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test10()
        {
            //arrange
            int a = -1;
            int b = 1;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test11()
        {
            //arrange
            int a = 1;
            int b = 1;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test12()
        {
            //arrange
            int a = -1;
            int b = -1;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test13()
        {
            //arrange
            int a = 5;
            int b = -5;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test14()
        {
            //arrange
            int a = -6;
            int b =  6;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test15()
        {
            //arrange
            int a = -5;
            int b = -6;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test16()
        {
            //arrange
            int a = -2;
            int b = -1;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test17()
        {
            //arrange
            int a = 1;
            int b = 2;
            bool neg = false;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test18()
        {
            //arrange
            int a = -5;
            int b = 6;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test19()
        {
            //arrange
            int a = -5;
            int b = -5;
            bool neg = true;

            //act
            bool result = BasicProgramming.PositiveNegative(a, b, neg);

            //assert
            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class BasicProgrammingCatHungrey
    {
        [TestMethod]
        public void Test1()
        {
            int a = 120;
            int b = -1;
           

            //act
            bool result = BasicProgramming.CatHungrey(a,b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            int a = -1;
            int b = 120;


            //act
            bool result = BasicProgramming.CatHungrey(a, b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            int a = 2;
            int b = 120;


            //act
            bool result = BasicProgramming.CatHungrey(a, b);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            int a = -1;
            int b = 100;


            //act
            bool result = BasicProgramming.CatHungrey(a, b);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test5()
        {
            int a = -2;
            int b = -2;


            //act
            bool result = BasicProgramming.CatHungrey(a, b);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test6()
        {
            int a = 120;
            int b = 120;


            //act
            bool result = BasicProgramming.CatHungrey(a, b);

            //assert
            Assert.AreEqual(false, result);
        }
    }

    [TestClass]
    public class BasicProgrammingIn10and20
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            int a = 12;
            int b = 99;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test2()
        {
            //arrange
            int a = 21;
            int b = 12;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test3()
        {
            //arrange
            int a = 8;
            int b = 99;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test4()
        {
            //arrange
            int a = 99;
            int b = 10;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test5()
        {
            //arrange
            int a = 20;
            int b = 20;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test6()
        {
            //arrange
            int a = 21;
            int b = 21;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test7()
        {
            //arrange
            int a = 9;
            int b = 9;


            //act
            bool result = BasicProgramming.In10and20(a, b);

            //assert
            Assert.AreEqual(false, result);
        }
    }
}