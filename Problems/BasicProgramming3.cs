using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class BasicProgramming3
    {
        /// <summary>
        /// We are given a string str that will be manipulated and a integer num which represents the factor of which charcters we want to pull from the string. For instance if num is 2, we want to return the chars at 0,2,4...num.length. The beginning will always start from zero so count from there and str will never be a empty string
        /// 
        /// Example: str = basketball, num =2         Output = bsebl  
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string EveryOther(string str, int num)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are given a string str and a integer num. Return a string that uses str to copy itself multiple times bases on what is passed in for num.
        /// 
        /// Example: str = 'cat' num = 3        Output: 'catcatcat'
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string StringTimesItSelf(string str, int num)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are given a string str. Return true if the first 'c' in str is followed by another 'c'.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        public static bool DoubleC(string str)
        {
            return false;
        }

        /// <summary>
        /// We are given a string str, create a new string consisting of every other character beginning with the first and return it.
        /// 
        /// example: str = hello  returned = hlo       --- it returns every other char
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MissingMiddle(string str)
        {
            return string.Empty;
        }

        /// <summary>
        /// We are given a string str, create a new string that adds itself each time over and over again that takes a predeccessor version of itself starting at the next specific index. For example if str is equal to 'cat', we would return 'ccacat'. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringPlosion(string str)
        {
            return string.Empty;
        }
    }
}
