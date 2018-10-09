using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Problems.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cats = { 0, 1, 2, 3 };

            


            // cats[0] = cats[cats.Length - 1];
            // cats[1] = cats[cats.Length - 2];

            // Move cats[1] to cats[0], cats[2] to cats[1]....... 

           // int[] cats = { 0, 1, 2, 3 };
           //
           // int i, dogs;
           // dogs = cats[0];
           //
           // for (i = 0; i < cats.Length - 1; i++)  /// Shifting the array --> i -> first postion -> full length till last char -> the Count;
           // cats[i] = cats[i + 1];  // cats + dog = cats[dogs + 1]  --> able to flip 
           // cats[i] = dogs; // dogs = 0; .....  
           //
           // System.Console.WriteLine(dogs);   ///Gives output of 0;


           //return cats;
           //
           //int[] cats = { 1, 2, 3, 4 };
           //int n = cats.Length;
           //
           //int i;
           //for (i = 1; i < n; ++i)
           //    cats[i - 1] = cats[i];
           //
           //System.Console.WriteLine("true ");


           //int[] cats = { 0, 1, 2, 3, 4 };
           //
           //int add = cats[0];
           //int length = cats.Length - 1;
           //
           //int sum = add + length;
           //
           //System.Console.WriteLine(add + length);
           //
           // //int sum = add + length;
           // System.Console.WriteLine(sum);
           //
           //if(add == length)
           //{
           //    System.Console.WriteLine(sum);
           //}
           //
           // int[] cats2 = new int[3] { 2, 5, 8 };
           // int sum2 = 0;
           //
           // for (int i = 0; i < cats2.Length; i++)
           // {
           //     sum2 += cats2[i];
           // }
           // System.Console.WriteLine("Sum of all elements stored in the array is : " + sum);
            //System.Console.WriteLine("Sum of all elements stored in the array is : " + arr.Sum());
            //// RemoteControl control = new RemoteControl("Black");
            //// RemoteControl control1 = new RemoteControl("Green");
            ////
            //// Button power = new Button("Power On");
            //// Button poweroff = new Button("Power Off");
            ////
            //// power.Push();   /// what about giving a prompted option to selcet 'A' Enter then print to screen "Power On"; 
            //// poweroff.Push(); //The same for power off?
            ////
            //// System.Console.Read();

            //System.Console.WriteLine(control.GetColor());
            //System.Console.WriteLine(control1.GetColor());
            //control1.SetColor("Purple");
            //System.Console.WriteLine(control.GetColor());
            //System.Console.WriteLine(control1.GetColor());
            //System.Console.Read();

            //string name = "cats";
            //int a = name[name.Length - 1];

            //System.Console.WriteLine(a);

            //char character = (char)inputA;
            //char character2 = (char)inputB;
            //string text = character.ToString();
            //
            //string asciichar = (Convert.ToChar(65)).ToString();
            //System.Console.WriteLine(asciichar);  // returns 'A'

            // Modulo operator notes 

            //int value = 5 % 3;  // output is '2'
            //System.Console.WriteLine(value);
            //int value2 =101 % 3;  // output is '2'
            //System.Console.WriteLine(value2);
            //int value3 = 99 % 3;  // output is '0'
            //System.Console.WriteLine(value3);
            //int value4 = 115 % 5;  // output is 'o'
            //System.Console.WriteLine(value4);

            // Modulo operator

            //double firstNumber = 14.40, secondNumber = 4.60, result;
            //int num1 = 26, num2 = 4, rem;
            //
            //// Addition operator
            //result = firstNumber + secondNumber;
            //System.Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
            //
            //// Subtraction operator
            //result = firstNumber - secondNumber;
            //System.Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
            //
            //// Multiplication operator
            //result = firstNumber * secondNumber;
            //System.Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
            //
            //// Division operator
            //result = firstNumber / secondNumber;
            //System.Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
            //
            //// Modulo operator
            //rem = num1 % num2;
            //System.Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);



            ////Messing around 

            //int inputA = 0;
            //int inputB = 0;
            //
            //string a = inputA.ToString();
            //char[] charArray = a.ToCharArray();
            //
            //string b = inputB.ToString();
            //char[] chararray2 = b.ToCharArray();

            /////  Testing sum method 


            ///// int[] arr1 = { 3, 5, 2, 5, 2 };
            ///// int[] arr2 = { 2, 3, 5, 5, 2 };
            /////
            ///// if (arr1 == arr2)
            /////     System.Console.WriteLine("return true");
            ///// else
            /////      System.Console.WriteLine("return false");
            //int[] catsA;
            //int[] catsB;





            //}
            // string[] planets = { "Mercury", "Venus", "Mars",
            //"Earth", "Jupiter",  "Saturn", "Uranus", "Neptune", "Pluto" };
            //
            //foreach (string planet in planets)
            //{
            //    System.Console.WriteLine(planet);
            //}
            ////  output is 25'
            //int[] numbers = { 4, 3, 8, 0, 5 };
            //
            //Array.Sort(numbers);
            //
            //foreach (int i in numbers)
            //    System.Console.WriteLine(i);



            // string name = "cats";
            //string lastchar = name.Substring(name.Length -1);  // gets Last char
            // string complete = name.Substring(0, 4);  /// gives 'cats'
            //string one = name.Substring(0, 1); // gets first Char
            //System.Console.WriteLine(one);
            //string length = name.Substring(0, name.Length - 0);  // gets cats' *****
            // System.Console.WriteLine(length);
            //string[] array = { "cats" };

            //****TESTING THE OUTPUT OF '%';  you will always get '0' if both inter go into eachother equally!****//
            //never have a remainder!



            ////******* Tying to understand LOOPS*********////

            // The dog string is at index 1.
            //int catIndex = Array.IndexOf(array, "cat");
            //return catIndex;
            //System.Console.WriteLine(catIndex);

            //// Create string array with no elements.
            //var empty1 = new string[] { };
            //System.Console.WriteLine(empty1.Length == 0);
            //
            //// This syntax has the same result.
            //var empty2 = new string[0];
            //System.Console.WriteLine(empty2.Length == 0);

            ////****** UNDERSTANDING LOOPS CONT****////

            /////string[] array = { "red", "blue", "green" };
            /////// Loop with for each and write colors with string interpolation.
            /////foreach (string color in array)
            /////{
            /////    System.Console.WriteLine($"Color = {color}");
            /////}



            //////***** TESTING 'e' Char question && start with******//////

            //string word = "vic";
            //sif (word.Substring(1, 3) == "c")
            //s
            //s   System.Console.WriteLine(word);
            //s
            ///int main(int a, b)
            ///{
            ///
            ///}
            ///int f = a;
            ///int s = b;
            ///
            ///if (a </= b)
            ///{
            ///    
            //We have a string parameter called mix. Return true if the string begins with 'cat', however
            /// the 'c' in 'cat' can be anything so 'bat','hat' are examples which will also return true
            /// </summary>
            /// <param name="mix"></param>
            /// <returns></returns
            ///// 
            //int n = 5, sum = 0;
            //
            //for (int i = 1; i <= n; i++)
            //{
            //    // sum = sum + i;
            //    sum += i;
            //}
            //
            //System.Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);






            ///when to use Substring vrs Length 
            //for (int i=0;i<10;i++)
            //{
            //    System.Console.WriteLine(name + name + name);
            //}
            //
            //string[] names = new string[3];
            //names[0] = "Theo";
            //names[1] = "Cueball";
            //names[2] = "russian";
            //
            //
            //int[] numbers = new int[2];
            //numbers[0] = 0;
            //numbers[1] = 1;
            //
            ////https://www.dotnetperls.com/array
            //
            //int catA; 
            //int catB;
            //int catC;
            //
            //int[] cats = new int[1000000];
            //
            //char[] letters = "test".ToCharArray();
            //
            //
            //char first = letters[0];

            //string test = value.Substring()

            /// easy way to get 'value'
            //string easy = value.Substring(0, 5);
            //System.Console.WriteLine(easy);
            //
            //string name2 = value.Substring(0, value.Length - 4);
            //string name3 = value.Substring(1, value.Length - 1);
            ////// gets value
            //System.Console.WriteLine(name2 + name3);

            // string str2 = value.Substring(0, 3);
            //System.Console.WriteLine(str2);
            //string str = value.Substring(value.Length - 2, 1);
            // string str2 = value.Replace()
            //if (str == value)
            // {
            //System.Console.WriteLine(value);
            // }


            //System.Console.WriteLine(complete2);

            //string two = value.Substring(value.Length -2, 1);  /// gives me 'a' Char;

            //System.Console.WriteLine(two);


            ///int index2 = value.IndexOf(' ', index1 + 1);
            ///string result = value.Remove(index2);

            // string result1 = test4.Remove(2);
            //System.Console.WriteLine(result1);
            //string name = "at";
            //string replace = name.Replace("cat", "");
            // string test = name.Substring(0, 1) + name.Replace("at", "") + name.Substring(0,name.Length - 1);
            //string test2 = name.Substring(1, name.Length - 2) + replace + name.Substring(0, name.Length - 1);
            //System.Console.WriteLine(test2);


            //string replace = stringchar.Replace("cat", "");
            //string complete = replace + test;
            //System.Console.WriteLine(first);
            //**string cat = name + name.IndexOf(name); /// index of cat == 0
            //** System.Console.WriteLine(cat);

            //string second = name.Substring(1, name.Length - 2);
            //string cat = name.Substring(0, 3);
            //string lasttwo = name.Substring(0, name.Length -1);
            //string complete = second + cat + lasttwo;
            //System.Console.WriteLine(complete);
            //string removecat = name.Remove(1);
            //System.Console.WriteLine(complete + removecat);

            //string secondchar = name.Substring(1, name.Length -1);  // gets me the 2nd Char 
            ///System.Console.WriteLine(second + cat);
            //string complete = value.Substring(1, 1); //+ value.Substring(1, value.Length - 1) + value.Substring(0, 3);
            //System.Console.WriteLine(complete);
            //string second = value.Substring(1, 1); //string the = value.Substring(1, value.Length - 2) + value + value.Substring(1, value.Length - 1);
            //System.Console.WriteLine(second);
            //string last = value.Substring(value.Length - 1, 1);
            //System.Console.WriteLine(last);

            //System.Console.WriteLine(middle);
            //string complete = second + middle + last;
            //System.Console.WriteLine(complete);
            //System.Console.WriteLine(the);
            //string first = value.Substring(0, 1);
            //string last = name.Substring(name.Length -1, 1);
            //string ochar = name.Substring(name.Length -2, 1);
            //string inbetween = name.Substring(1,name.Length -2);
            //string firstthree = name.Substring(0, name.Length -3);
            //string firsttwo = name.Substring(0, 2);
            //string str = name.Substring(name.Length - 1, 1);
            //string str2 = name;
            //string str3 = str + str;
            //string str2 = firstthree + firstthree + firstthree; 

            //System.Console.WriteLine(last);
            //System.Console.WriteLine(ochar);
            //System.Console.WriteLine(inbetween);
            //System.Console.WriteLine(firstthree);
            //System.Console.WriteLine(firsttwo);
            //System.Console.WriteLine(str + str2 + str3);
            //System.Console.WriteLine(str2);

        }


    }
}
