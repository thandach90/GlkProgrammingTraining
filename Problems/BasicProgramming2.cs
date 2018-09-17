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
            if (value.Length < 2)
            {
                return value;
            }

            string complete = value.Substring(value.Length - 1, 1) + value.Substring(1, value.Length - 2) + value.Substring(0, 1);
            return complete;


        }

        //// ******** second part of questions***********

        /// <summary>  
        /// We are passed the string parameter named value. Return a new string which gets the first three 
        /// letters of value and concats those letters three times. If the string is less than 3 letters, 
        /// return back the original string concated 3 times
        /// For Example: value = 'abc' return 'abcabcabc'
        ///              value = 'house' return 'houhouhou'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static string FirstThree(string value)
        {

            if (value.Length < 3)
            {
                return value + value + value;
            }

            string name = value.Substring(0, 3);
            {
                return name + name + name;
            }


        }

        /// <summary>
        /// We are given the string parameter name value. Return a new string which gets the last character 
        /// from value and adds it to the front and back.
        /// For Example: value = 'cat' return 'tcatt'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string BringItBack(string value)
        {
            string lastchar = value.Substring(value.Length - 1, 1);
            return lastchar + value + lastchar;
        }

        /// <summary>
        /// We are given a string parameter name value. Return a new string which takes the first 
        /// two characters and adds them to the front and back of value. If the length of value is 
        /// less than two, than use whatever characters are there
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static string BringItBackTwice(string value)
        {

            if (value.Length < 2)
            {
                return value + value + value;
            }

            string firsttwo = value.Substring(0, 2);
            return firsttwo + value + firsttwo;

        }

        /// <summary>)
        /// If the string parameter value begins with 'cat' return 'true' else return 'false'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool StartWithCat(string value)
        {
            //dont start with, use substring
            if (value.Length >= 3 && value.Substring(0, 3) == "cat")
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        /// <summary>
        /// We are given two integer parameters, numA and numB. 
        /// Return true if one is less than zero and the other is greater than 100
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns></returns>
        public static bool ZeroToHundered(int numA, int numB)
        {
            if ((numB <= 0 && numA >= 0) || (numA < 100 && numB > 100))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// We are given two integer parameters, numA and numB. Return true if numA or numB is between 
        /// 10 and 20 inclusive
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns></returns>
        public static bool CaughtBetween10And20(int numA, int numB)
        {
            if ((numB >= 10) && (numB <= 20) || (numA >= 10) && (numA <= 20))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// We have three cats whose age in months is passed by the parameters catA,catB,and catC. 
        /// We want to determine if they are still kittens or not. A cat is a kitten if its age is 
        /// between 13-19 months (inclusive). Return true if any of them are kittens, else return false 
        /// if all of them aren't.
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <param name="catC"></param>
        /// <returns></returns>
        public static bool IsItACatOrKitten(int catA, int catB, int catC)
        {

            if ((catA >= 13) && (catA <= 19) || (catB >= 13) && (catB <= 19) || (catC >= 13) && (catC <= 19))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// We have two cats whose age in months is passed in by the parameters catA and catB. 
        /// A cat is a kitten if its age is between 13-19 months(inclusive). 
        /// Return true if either cat is a kitten but not both of 
        /// them 
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <returns></returns>
        public static bool IsOneAKitten(int catA, int catB)
        {
            if ((catA >= 13 && catA <= 19) && (catB >= 13 && catB <= 19))
            {
                return false;
            }
            return ((catA >= 13 && catA <= 19) || (catB >= 13 && catB <= 19));


        }

        /// <summary>
        /// We have a string parameter value. If the parameter contains the value 'cat' 
        /// beginning at index 1, return back the string value with 'cat' removed, else 
        /// return the original string
        /// 
        /// For example: value = 'acatbc' return 'abc'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DeleteCat(string value)
        {
            if (value.Length >= 4)
            {
                string start = value.Substring(1, 3);
                if (start == "cat")
                {
                    return value.Replace("cat", "");  // Remove(1) ? How to use the removel ? 
                }
            }
            return value;
        }

        //// ******** 3rd part of questions***********

        /// <summary>
        /// We have a string parameter called mix. Return true if the string begins with 'cat', however 
        /// the 'c' in 'cat' can be anything so 'bat','hat' are examples which will also return true
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public static bool CatMix(string mix)  //// need to go over 
        {

            if ((mix.Length < 3 && (mix.Substring(1, 3) == ("at")))) 
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// We have three cats whose weight is stored in catA,catB,and catC. 
        /// Return the heaviest cat
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <param name="catC"></param>
        /// <returns></returns>

        public static int LargestCat(int catA, int catB, int catC)
        {
            int weight = 0;

            if (catA > catB)
            {
                weight = catA;
            }

            else
            {
                weight = catB;
            }
               
            if (catC > weight)
            {
                weight = catC;
            }
                
            return weight;
        }

        /// <summary>
        /// We are given two integer parameters catA and catB which represents a cats weight. 
        /// Return the weight of the cat closest to 10. If they are tied in how close to ten they are, return zero.
        /// For example: if catA is 8 and catB is 9, return catb which is 9
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <returns></returns>
        public static int GetClosetCatToTen(int catA, int catB)
        {
            int weight =  Math.Abs(10 - catA);  //// Math.Abs -  absolute value of a int.
            int weight2 = Math.Abs(10 - catB);   
                                                ///// Just like BasicProgramming1 problem
            if (weight < weight2)
            {
                return catA;
            }
                
            else if (weight2 < weight)
            {
                return catB;
            }
                
            return 0;
        }

        /// <summary>
        /// We are given a string parameter str, 
        /// return true if str contains between 1 and 3 'e' characters
        /// Dont do this one till we learn about loops
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool GetStringE(string str)  //// Loops 
        {
            {   ///https://www.programiz.com/csharp-programming/for-loop

                ///for (initialization; condition; iterator)

                // body of for loop

                ///initialization statement is int i = 1
                ///condition statement is i </= 5
                ///iterator statement is i++
                return false;
            }
           
        }
               
        

        /// <summary>
        /// This will be a research question. Please research the modulus operator '%' 
        /// and figure out its functionality. You will need it to solve the following problem. 
        /// A important skill in programming is looking up commands and figuring out how to use them
        /// We are given a integer parameter input, return true if input is a multiple of 3 or 5.
        /// example: 3 = true, 10 = true, 8 = false
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ThreeOrFive(int input)
        {
            // % checks for * of a inter;
            int n = 0;
            while(n < 0)
            {
                return true;
            }
            if(n % 3 == 0 || n % 5 == 0)
            {
                return true;
            }
            return false;
        }
  
    /// <summary>
    /// We are given two integer parameters inputA and inputB which will always be positive. 
    /// Return true if they both have the same last digit. 
    /// For example: inputA = 7 and inputB = 17 will return true
    /// </summary>
    /// <param name="inputA"></param>
    /// <param name="inputB"></param>
    /// <returns></returns>
    public static bool GetTheLastDigit(int inputA, int inputB)
        {
            return false;
        }

        /// <summary>
        /// Please create and return a new array containing three 7s
        /// Don't overthink this one :)
        /// array = [7,7,7]
        /// </summary>
        /// <returns></returns>

        public static int[] CreateLucky7s()
        {
            return null;
        }

        /// <summary>
        /// We are given a array of integers called cats. Return true if a 6 is located in the first or last index else return false
        /// 
        /// for example: [1,2,6] = true
        /// </summary>
        /// <param name="cats"></param>
        /// <returns></returns>
        public static bool SixFirstLast(int[] cats)
        {
            return false;
        }

        /// <summary>
        /// We are given a array of integers called cats. Return true if cats array length is greater or equal to 1, also if the first and last elements in the array are equal
        /// </summary>
        /// <param name="cats"></param>
        /// <returns></returns>
        public static bool SameFirstLast(int[] cats)
        {
            return false;
        }


        /// <summary>
        /// We are given two int arrays named catsA and catsB. If catsA and catsB share the same first element or share the same last element return true, else return false
        /// </summary>
        /// <param name="catsA"></param>
        /// <param name="catsB"></param>
        /// <returns></returns>
        public static bool CatEnds(int[] catsA, int[] catsB)
        {

            return false;
        }

        /// <summary>
        /// We are given a int array parameter named cats. Cats will always be a length of 3. Please add up all the integers in cats and return the sum.
        /// </summary>
        /// <param name="cats"></param>
        /// <returns></returns>
        public static int CatSum3(int[] cats)
        {
            return 0;
        }

        /// <summary>
        /// We are given a integer array called cats. Return cats array where each index goes left 'rotated left'. The array cats will always be length of 3.
        /// 
        /// example: [1,2,3] rotated left is [2,3,1]
        ///          [5,11,9] rotated left is [11,9,5]
        /// </summary>
        /// <param name="cats"></param>
        /// <returns></returns>
        public static int[] CatsRotateLeft(int[] cats)
        {

            return cats;
        }


    }




}




    

