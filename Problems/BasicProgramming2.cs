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
    }
}
