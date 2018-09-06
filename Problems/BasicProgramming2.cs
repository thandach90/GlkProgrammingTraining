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
            return "cat" + value;
        }

        /// <summary>
        /// Given a string parameter 'value', return the first character from the string. 
        /// Hint: take a look at the substring method on the string class 
        /// or access the string by index
        /// </summar 
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CatSubString(string value)
        {
            return value.Substring(0, 1);
        }


        /// <summary> 
        /// Given the string parameter value, add 'cat' to the front of the string. 
        /// If the string value parameter already begins with 'cat', return the string unchanged.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DoesStringContainCat(string value)
        {
            if (value.Substring(0, 3) == "cat")
            {
               return value;
            }
            
            return CatString(value);
        }

        /// <summary>
        /// Given the string parameter value, remove the character specified by the int parameter index
        /// Example: value "cat", index="1", result = "ct"
        /// Hint: take a look at the string remove method or the replace method for a bigger challenge
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string CatIsMissingSomething(string value, int index)
        {
            return value.Remove(index, 1);
        }
            
       

        /// <summary>
        /// Using the string parameter value, flip the first and last charactors
        /// example: code = eodc
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SwappedCat(string value)
        {
            if(value.Length < 2)
            {
                return value;
            }
            string complete = value.Substring(value.Length - 1, 1) + value.Substring(1, value.Length-2) + value.Substring(0, 1);
            {
                return complete;
            }  
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
    }
}
