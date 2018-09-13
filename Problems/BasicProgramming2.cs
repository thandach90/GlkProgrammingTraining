using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class BasicProgramming2
    {

        /// <summary>
        /// Given a string parameter 'value', return the string with 'cat' added to the front.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CatString(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Given a string parameter 'value', return the first character from the string. 
        /// Hint: take a look at the substring method on the string class or access the string by index
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CatSubString(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Given the string parameter value, add 'cat' to the front of the string. If the string value parameter already begins with 'cat', return the string unchanged.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DoesStringContainCat(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Given the string parameter value, remove the character specified by the int parameter index
        /// 
        /// Example: value "cat", index="1", result = "ct"
        /// Hint: take a look at the string remove method or the replace method for a bigger challenge
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string CatIsMissingSomething(string value, int index)
        {
            return string.Empty;
        }

       

        /// <summary>
        /// Using the string parameter value, flip the first and last charactors
        /// example: code = eodc
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SwappedCat(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are passed the string parameter named value. Return a new string which gets the first three letters of value and concats those letters three times. If the string is less than 3 letters, return back the original string
        /// 
        /// 
        /// For Example: value = 'abc' return 'abcabcabc'
        ///              value = 'house' return 'houhouhou'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static string FirstThree(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are the string parameter name value. Return a new string which gets the last character from value and adds it to the front and back.
        /// 
        /// For Example: value = 'cat' return 'tcatt'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string BringItBack(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are given a string parameter name value. Return a new string which takes the first two characters and adds them to the front and back. If the length of value is less than two, than use whatever characters are there
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static string BringItBackTwice(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// If the string parameter value begins with 'cat' return 'true' else return 'false'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool StartWithCat(string value)
        {
            return false;
        }

        /// <summary>
        /// We are given two integer parameters, numA and numB. Return true if one is less than zero and the other is greater than 100
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns></returns>
        public static bool ZeroToHundered(int numA, int numB)
        {
            return false;
        }

        /// <summary>
        /// We are given two integer parameters, numA and numB. Return true if numA or numB is between 10 and 20 inclusive
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns></returns>
        public static bool CaughtBetween10And20(int numA, int numB)
        {
            return false;

        }

        /// <summary>
        /// We have three cats whose age in months is passed by the parameters catA,catB,and catC. We want to determine if they are still kittens or not. A cat is a kitten if its age is between 13-19 months (inclusive). Return true if any of them are kittens, else return false if all of them aren't.
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <param name="catC"></param>
        /// <returns></returns>
        public static bool IsItACatOrKitten(int catA, int catB, int catC)
        {
            return false;
        }

        /// <summary>
        /// We have two cats whose age in months is passed in by the parameters catA and catB. A cat is a kitten if its age is between 13-19 months(inclusive). Return true if either cat is a kitten but not both of them 
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <returns></returns>
        public static bool IsOneAKitten(int catA, int catB)
        {
            return false;
        }

        /// <summary>
        /// We have a string parameter value. If the parameter contains the value 'cat' beginning at index 1, return back the string value with 'cat' removed, else return the original string
        /// 
        /// For example: value = 'acatbc' return 'abc'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DeleteCat(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// We have a string parameter called mix. Return true if the string begins with 'cat', however the 'c' in 'cat' can be anything so 'bat','hat' are examples which will also return true
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public static bool CatMix(string mix)
        {
            return false;
        }

        /// <summary>
        /// We have three cats whose weight is stored in catA,catB,and catC. Return the heaviest cat
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <param name="catC"></param>
        /// <returns></returns>

        public static int LargestCat(int catA, int catB, int catC)
        {
            return 0;
        }

        /// <summary>
        /// We are given two integer parameters catA and catB which represents a cats weight. Return the weight of the cat closest to 10. If they are tied in how close to ten they are, return zero.
        /// 
        /// For example: if catA is 8 and catB is 9, return catb which is 9
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <returns></returns>
        public static int GetClosetCatToTen(int catA, int catB)
        {
            return 0;
        }

        /// <summary>
        /// We are given a string parameter str, return true if str contains between 1 and 3 'e' characters
        /// 
        /// For example - cat returns true , ccccat returns false
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool GetStringE(string str)
        {
            return false;
        }

        /// <summary>
        /// This will be a research question. Please research the modulus operator '%' and figure out its functionality. You will need it to solve the following problem. A important skill in programming is looking up commands and figuring out how to use them
        /// 
        /// We are given a integer parameter input, return true if input is a multiple of 3 or 5.
        /// 
        /// example: 3 = true, 10 = true, 8 = false
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ThreeOrFive(int input)
        {
            return false;
        }

        /// <summary>
        /// We are given two integer parameters inputA and inputB which will always be positive. Return true if they both have the same last digit.
        /// 
        /// For example: inputA = 7 and inputB = 17 will return true
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns></returns>
        public static bool GetTheLastDigit(int inputA, int inputB)
        {
            return false;
        }
    }
}
