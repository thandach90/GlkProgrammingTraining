using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Console
{
    class Program
    {

       
        static void Main(string[] args)
        {
            string value = "value";
            string name = value.Substring(0, 5);  // name = value.Substring(1, value.Lenght -2);
            if (name.Length >= 5)
            {
                System.Console.WriteLine(value.Contains("value"));
            }

            ///when to use Substring vrs Length 
            ///

            for(int i=0;i<10;i++)
            {
                System.Console.WriteLine(name + name + name);
            }
                          
            
            
            

            //string test = value.Substring()

            /// easy way to get 'value'
            string easy = value.Substring(0, 5);
            System.Console.WriteLine(easy);

            string name2 = value.Substring(0, value.Length - 4);
            string name3 = value.Substring(1, value.Length - 1);
           //// gets value
            System.Console.WriteLine(name2 + name3);

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
