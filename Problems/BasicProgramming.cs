using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public static class BasicProgramming
    {
        private static readonly int sum;

        /// <summary>
        /// We have two cats, a and b, and the parameters aYawn and bYawn indicate if each is yawning, so if aYawn is true then cat a is yawning. We are in trouble if they are both yawning or if neither of them is yawning. Return true if we are in trouble.
        /// </summary>
        /// <param name="aYawn"></param>
        /// <param name="bYawn"></param>
        /// <returns></returns>
        public static bool IsTrouble(bool aYawn, bool bYawn)
        {
            if ((aYawn == true && bYawn == true) || (aYawn == false && bYawn == false))
            {
                return true;
            }
            else
            {
                return false;
            }

            //if (aYawn == bYawn)
            //    return true;
            //else
            //{
            //    return false;
            //}
        }



        /// <summary>
        /// The parameter weekday is true if its a weekday and false if its on the weekend. The parameter golf is true if we play golf and false if we don't. If its a weekday and we play golf we play hooky, we also play hooky if its not a weekday so return true for these two conditions.
        /// </summary>
        /// <param name="weekDay"></param>
        /// <param name="golf"></param>
        /// <returns></returns>
        public static bool IsHooky(bool weekDay, bool golf)
        {
            if (weekDay == false)
            {
                return true;
            }


            if (weekDay == true && golf == true)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Our cat likes to meow. The parameter hour is the time in the range between 0 and 23. We are angry if the cat is meowing and the hour is before 7 or after 20. Return true if we are angry
        /// </summary>
        /// <param name="meowing"></param>
        /// <param name="hour"></param>
        /// <returns></returns>

        public static bool CatMakesUsAngry(bool meowing, int hour)
        {
            if ((meowing == true) && (hour < 7 || hour > 20))
            {
                return true;
            }

            return false;

        }




        /// <summary>
        /// Given two bowls of food represented by variables, food and food2, 
        /// return true if one bowl has less than 0 food (-1,-2) and the other 
        /// bowl has more than 100
        /// </summary>
        /// <param name="food"></param>
        /// <param name="food2"></param>
        /// <returns></returns>

        public static bool CatHungrey(int food, int food2)
        {
            if ((food < 0) && (food2 > 100) || (food > 100) && (food2 < 0))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Given 2 int values, return true if either of them is in the range 10..20 inclusive.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool In10and20(int a, int b)
        {
            if ((a >= 10) && (a <= 20) || (b >= 10) && (b <= 20))
            {
                return true;
            }
            return false;
        }



        /// <summary>
        /// We have two cats whose parameters represent their age, catA and catB, 
        /// return true if one is 10 years old or if combined they equal 10 years of age 
        /// </summary>
        /// <param name="catA"></param>
        /// <param name="catB"></param>
        /// <returns></returns>

        public static bool TenYearOldCat(int catA, int catB)
        {
            if ((catA == 10) || (catB == 10))
            {
                return true;
            }

            if (catA + catB == 10)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// The parameter represents how many feet it will take our cat to reach his litter box. 
        /// If the cat is within 10 of 100 feet or within 10 of 200 feet then the cat is close. 
        /// So if 93 is passed in as feet then we return true, also if 193 is passed then we return true
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public static bool IsCatClose(int feet)
        {
            if((feet >= 90) && (feet <= 110) || (feet >= 190) && (feet <= 210))
            {
                return true;
            }

            return false;
        }
          

        /// <summary>
        /// Given two int values, return their sum. Unless the two values are the same, 
        /// then return double their sum.
        /// </summary>
        /// <param name="second"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static int DoubleSum(int second, int first)
        {
            
           if(first == second)
            {
                int sum = (first +second)*2;
                return sum;
            }

           else
            {
                int sum = first + second;
                return sum;
            }
            
        }

        /// <summary>
        /// There is an input provided, calculate the absolute-difference between 
        /// input and 21 and return the output. If input is over 21  return double 
        /// the result of the absolute-difference.
        /// Hint- Take a look at the Math.Abs() .net method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int DifferenceOf21(int input)
        {
            if(input >= -21)
            {
                return (input - 21) * 2;
            }

            return input - 21;
          
        }


        /// <summary>
        /// We have two int parameters, a and b , if one is negative and one is positive return back true. 
        /// If the parameter negative is true, then only return true if both a and b are negative
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="negative"></param>
        /// <returns></returns>

        public static bool PositiveNegative(int a, int b, bool negative)
        {

            if (negative == true )
            {
                if ((a < 0) && (b < 0))
                {
                    return true;
                }
                return false;
            }

            if ((a < 0) && (b > 0) || (a > 0) && (b < 0))
            {
                return true;
            }

           

            return false;  
        }
    }
}
