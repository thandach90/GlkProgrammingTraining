using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ConsoleForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {


            //////////// Array Rotation /////////////////
            int[] cats = { 0, 1, 2, 3 };

            int n = cats[0];
            int last = cats[cats.Length - 1];


            ///////// same last Digit ///////
            int input1 = 0;
            int input2 = 0;

            if (input1 % 10 == input2 % 10)
            {
                Console.WriteLine(input1 + input2);
            }

            //string[] array = { "vic", "the", "man" };
            //
            //// Use Array.Exists in different ways.
            //bool a = Array.Exists(array, element => element == "vic");  /// True
            //bool b = Array.Exists(array, element => element == "man");  ///True
            //bool c = Array.Exists(array, element => element.StartsWith("the"));  //True
            //bool d = Array.Exists(array, element => element.StartsWith("vtm"));  // False 
            //
            //// Display bools.
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            // int thesenuts = 12345;  // get back 54321;
            // int left = thesenuts;
            // int rev = 0;
            // while (left > 0)
            // {
            //     int r = left % 10;
            //     rev = rev * 10 + r;
            //     left = left / 10;  //left = Math.floor(left / 10); 
            // }
            //
            // Console.WriteLine(rev);

            // int[] arr = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            // int n = arr.Length;
            // int key = 6;
            // int i = search(arr, 0, n - 1, key);
            //
            // if (i != -1)
            //     Console.WriteLine("Index: " + i);
            // else
            //     Console.WriteLine("Key not found");



            //int[] nums = { 1, 2, 8 };
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            //var temp = nums[0];
            //for (var i = 0; i < nums.Length - 1; i++)
            //{
            //    nums[i] = nums[i + 1];
            //}
            //nums[nums.Length - 1] = temp;
            //Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));



            //int[] arr = [1, 2, 3, 4, 5, 6, 7], d = 2, n = 7;
            //    //Store d elements in a temp array
            //int[] temp = [1, 2];
            //    // Shift rest of the arr[]
            //int[] arr2 = [3, 4, 5, 6, 7, 6, 7];
            //    // Store back the d elements
            //int[] arr4 = [3, 4, 5, 6, 7, 1, 2]




            //string str = "heeteeet";
            //int count = 0;
            //string e = str;
            //
            //
            //foreach (e in str )
            //{
            //    i++;
            //}

            ////////Loops Test Examples//////////

            //nt occurence = 0; // the number of consecutive occurences
            //or (int i = 0; i < s.Length; i++)
            //
            //   if (s[i] == c)
            //   { // If you encounter the character
            //       occurrence++; // Increase the counter
            //   }
            //   else
            //   { // If another character occurs
            //       if (occurence == 2)
            //       {
            //           // Check if the number of consecutive occurences was exactly 2
            //          return true;
            //       }
            //       // If not, reset the counter
            //       occurence = 0;

            //int numbers = 10;
            //
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //string longest = b.Length > a.Length ? b : a;
            //string shorten = b.Length > a.Length ? a : b;
            //for (int i = 0; i < shorten.Length; i++)
            //{
            //    if (shorten[i] != longest[i])
            //    {
            //        Console.WriteLine(i);
            //    }

            // int number = 2;
            // bool isEven;
            //
            // isEven = (number % 2 == 0) ? true : false;
            // Console.WriteLine(isEven);

            // string str = "heete";



            //string s = "Kill all cats";
            //// Split string on spaces.
            //// ... This will separate all the words.
            //string[] words = s.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //
            //string str = "Abc,123";
            //foreach (char value in str)
            //{
            //    bool digit = char.IsDigit(value);
            //    Console.Write(value);
            //    Console.Write(' ');
            //    Console.WriteLine(digit);
            //}



            // string s = "findRepeatFirstN2";
            //
            // // this is O(N^2) method 
            // int p = -1, i, j;
            // for (i = 0; i < s.Length; i++)
            // {
            //     for (j = i + 1; j < s.Length; j++)
            //     {
            //         if (s[i] == s[j])
            //         {
            //             p = i;
            //             break;
            //         }
            //     }
            //     if (p != -1)
            //         break;
            // }
            //
            // Console.WriteLine(p);





            //// Driver code 
            //static public void Main()
            //{
            //    string str = "geeksforgeeks";
            //    //int pos = findRepeatFirstN2(str);
            //
            //    if (pos == -1)
            //        Console.WriteLine("Not found");
            //    else
            //        Console.WriteLine(str[pos]);
            //    string test = "heeehehe";
            //
            //    //for (int i = 0; i < test.Length; i++)
            //    //{
            //
            //    //Console.WriteLine(test[i]);
            //    //}
            //
            //    foreach (char name in test)
            //    {
            //        Console.WriteLine(name);
            //    }


            /// <summary>
            /// Returns whether the char is a digit char.
            /// Taken from inside the char.IsDigit method.
            /// </summary>


            //return ((c >= '0') && (c <= '9'));




            //string str4 = "cat";
            //
            //    // Use for-loop from 0 through Length of string (goes to last index).
            //    for (int i = 0; i < str4.Length; i++)
            //    {
            //        char test1 = str4[i];
            //        System.Console.WriteLine(test1);
            //    }
            //
            //    if (str.Contains("e"))
            //    {
            //        Console.WriteLine("Value of i: {0}", true);
            //    }
            //
            //Console.Write("Input a string (conatins at least one 'w' char) : ");
            //string str3 = Console.ReadLine();
            //var count = str3.Count(so => so == 'e');
            //Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            //Console.WriteLine(count >= 1 && count <= 3);

            //string str = "nameccccc";
            //
            //string test = str.Substring(str.Length);
            //
            //for(int i = 0; i < 3; i++)
            //{
            //   
            //    if (str[i] == e)
            //        Console.WriteLine("true");
            //}
            //
            //Console.WriteLine(test);
            //
            //for (char c = 'e'; c <= 'e'; c++)
            //{
            //    Console.WriteLine("true " );
            //}



            /// We are given a string parameter str, 
            /// return true if str contains between 1 and 3 'e' characters
            /// Dont do this one till we learn about loops
            /// 

            //string str = "ehh";
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    char e = str[i];
            //    if (e == 3)
            //    Console.WriteLine("Value of i: {0}", i);
            //}

            // string str = "I have a cat";
            //
            // int i = 0;
            // while((i = str.IndexOf('e', i)) != -1)
            // {
            //     Console.WriteLine(str.Substring(i));
            //
            //     i++;
            // }

            // int NO = 256;
            // char[] count = new char['e'];
            //
            // for (int i = 0; i < str.Length; i++)
            //     count[str[i]]++;



            //string[] str = {"e"};
            //
            //for(int i = 0; i < str.Length; i++)
            //{
            //    char c = 'e';
            //    if ()
            //   
            //       
            //}




            //int count;
            //
            //for (count = 0; count < 5; count = count + 1)
            //    Console.WriteLine("This is count: " + count);
            //
            //Console.WriteLine("Done");



            //this is count: 0 --> 4


            //int createint = 0;
            //
            //while(createint < 10)
            //{
            //    Console.WriteLine("{0} ", createint);
            //    createint++;
            //}
            //Console.ReadLine();

            //int i, j;
            //bool done = false;
            //
            //for (i = 0, j = 100; !done; i++, j--)
            //{
            //
            //    if (i * i >= j) done = true;
            //
            //    Console.WriteLine("i, j: " + i + " " + j);

            /// for loop example
            /// This is usualy used for boolen 

            //     for (int i = 0; i < 20; i++)
            // {
            //
            //     if (i == 10)
            //         break;   /// like a pause before next if()
            //
            //     if (i % 2 == 0)
            //         continue;
            //
            //     Console.Write("{0} ", i);
            //
            // }
            // Console.WriteLine();

            /////// foreach loop 

            // string[] names = { "Miro", "Theo", "Vlad", "Vic" };
            //
            // foreach(string person in names)
            // {
            //     Console.WriteLine("{0} ", person);
            // }

            ///// the do loop //////    

            //string myChoice;
            //
            //do
            //
            //{
            //    // Display on Console 
            //    Console.WriteLine("My Address Book\n");
            //
            //    Console.WriteLine("A - Add New Address");
            //    Console.WriteLine("D - Delete Address");
            //    Console.WriteLine("M - Modify Address");
            //    Console.WriteLine("V - View Addresses");
            //    Console.WriteLine("Q - Quit\n");
            //
            //    Console.WriteLine("Choice (A,D,M,V,or Q): ");
            //
            //    // Retrieve the user's choice
            //    myChoice = Console.ReadLine();
            //
            //    // Make a decision based on the user's choice
            //    switch (myChoice)
            //    {
            //        case "A":
            //        case "a":
            //            Console.WriteLine("You wish to add an address.");
            //            break;
            //        case "D":
            //        case "d":
            //            Console.WriteLine("You wish to delete an address.");
            //            break;
            //        case "M":
            //        case "m":
            //            Console.WriteLine("You wish to modify an address.");
            //            break;
            //        case "V":
            //        case "v":
            //            Console.WriteLine("You wish to view the address list.");
            //            break;
            //        case "Q":
            //        case "q":
            //            Console.WriteLine("Bye.");
            //            break;
            //        default:
            //            Console.WriteLine("{0} is not a valid choice", myChoice);
            //            break;
            //    }
            //
            //    // Pause to allow the user to see the results
            //    Console.Write("press Enter key to continue...");
            //    Console.ReadLine();
            //    Console.WriteLine();
            //} while (myChoice != "Q" && myChoice != "q"); 
            // Keep going until the user 



            //string[] array = { "red", "blue", "green" };
            //// Loop with for each and write colors with string interpolation.
            //foreach (string color in array)
            //{
            //    System.Console.WriteLine($"Color = {color}");
            //}




            // string str2 = "test";
            // 
            // int count = 0;
            // 
            // 
            // for (int i = 0; i < str2.Length; i++)
            // {
            // 
            //    char c = str2[i];
            //     if (c == 't')
            //         count++;
            // 
            // }
            // 
            // Console.WriteLine("The number of t letters is: " + count);
            // Console.Read();


            // string[] array = new string[6];
            // array[0] ="cat";
            // array[1] = "carrot";
            // array[2] = "rat";
            // array[3] = "bigger cat";
            // array[4] = "carrot";
            // array[5] = "apple";
            //
            // int count = 0;
            //
            // for(int i = 0; i < array.Length; i++)
            // {
            //    
            //     for(int j=0;j<array[i].Length;j++)
            //     {
            //         if(array[i][j] == 'a')
            //         {
            //             count++;
            //         }
            //     }
            //
            // }
            //
            // Console.WriteLine(count);
            // Console.Read();






            //
            // Example string array is declared.
            //
            //string[] array = new string[6];
            //array[0] = null;
            //array[1] = "carrot";
            //array[2] = "rat";
            //array[3] = "";
            //array[4] = "carrot";
            //array[5] = "apple";
            //
            ////
            //// Find string with this value starting at offset 2.
            ////
            //int index1 = Array.IndexOf(array, "carrot", 2, 3);
            //
            ////
            //// Find a nonexistent string.
            ////
            //int index2 = Array.IndexOf(array, "banana");
            //
            ////
            //// Write the result.
            ////
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);

            //int[] array = new int[6];
            //
            //
            //array[1] = 3;
            //array[2] = 5;
            //array[3] = 7;
            //array[4] = 8;
            //array[5] = 5;
            //
            //
            // //index for 5
            //
            //int index1 = Array.IndexOf(array, 5);
            //
            //
            //// index for 3
            //
            //int index2 = Array.IndexOf<int>(array, 3);
            //
            //
            //// last index for 5.
            //
            //int index3 = Array.LastIndexOf(array, 5);
            //
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);
            //Console.WriteLine(index3);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Value of i: {0}", i);
            //}
            //
            //
            //// Exit when x becomes greater than 4 
            //int x = 1;
            //
            //// Exit when x becomes greater than 4 
            //while (x <= 5)
            //{
            //    Console.WriteLine("Vic is the man, Cast sux");
            //
            //    // Increment the value of x for 
            //    // next iteration 
            //    x++;
            //}
            /////** 
            //foreach (char e in str)


            //string str = "eeed";
            //
            //int i = str.IndexOf('e');
            //string d = str.Substring(i);
            //Console.WriteLine(d);

            //string str = "eeed";

            //string first = str.Substring(0, 1);  /// first Char
            //string last = str.Substring(str.Length - 1);  /// last char
            // string sec = str.Substring(0, 3);
            //string complete = first + last;

            //  Console.WriteLine(complete);

            // int outerLoop = 0, innerLoop = 0;
            // for (int i = 1; i <= 5; i++)
            // {
            //     outerLoop++;
            //     for (int j = 1; j <= 5; j++)
            //     {
            //         innerLoop++;
            //     }
            // }
            // Console.WriteLine("Outer Loop runs {0} times", outerLoop);
            // Console.WriteLine("Inner Loop runs {0} times", innerLoop);

            // for (int i = 0; i < 5; i++)
            // {
            //     // body of outer for loop
            //     for (int j = 0; j < 5; j++)
            //     {
            //         // body of inner for loop
            //     }
            //     // body of outer for loop

            //char[] myArray = {'e'};
            //
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //
            //char[] str = { 'H', 'e', 'l', 'l', 'o' };
            //
            //foreach (char ch in str)
            //{
            //    Console.WriteLine(ch);
            //}
            //
            //char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            //int male = 0, female = 0;
            //foreach (char g in gender)
            //{
            //    if (g == 'm')
            //        male++;
            //    else if (g == 'f')
            //        female++;
            //}
            //Console.WriteLine("Number of male = {0}", male);
            //Console.WriteLine("Number of female = {0}", female);

            /////////Sum LOOP question ////////

            //var numbers = new List() { 5, -8, 3, 14, 9, 17, 0, 4 };
            //int sum = 0;
            //
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine("Sum = {0}", sum);


            // int[] arr = { 0, 1, 2, 3 };
            //
            // int x = 1 ;
            //
            // int n = arr.Length;
            // int first = -1, last = -1;
            //
            // for (int i = 0; i < n; i++)
            // {
            //     if (x != arr[i])
            //         continue;
            //     if (first == -1)
            //         first = i;
            //     last = i;
            // }
            // if (first != -1)
            // {
            //     Console.WriteLine(first);
            //     Console.Write(last);
            // }
            // else
            //     Console.Write("Not Found");

            // int test =  (cats.length - 1) == -1;
            //
            // int[] a = { 1, 2, 6, 3, 4, 5 };
            // int[] b = { 2, 4, 3, 1, 0 };
            //
            //
            // int m = b.Length;
            //
            // Console.WriteLine(a);

            // var numbers = new double[] { 0, 6 };
            //
            // var result = numbers.Sum(x => x == 6 ? 6 : 1);
            // Console.WriteLine(result);

            // int[] cats = { 0, 1, 2, 3};

            // int n = 0;

            //int[] b = { 2 };

            //int n = 3;

            //int m = 4;

            //for (int i = 0; i < n; i++)
            // {
            //  int j;

            //    Console.Write(cats[i]);
            //number % 10 will give you the last digit
            //int[] arr = new int[] { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //   Console.WriteLine(sum += arr[i]);
            //}

            //Console.WriteLine(complete);

            //Console.WriteLine(begin);

            // int[] array = new int[5];
            //
            // array[0] = 1;
            // array[1] = 2;
            // array[2] = 3;
            // array[3] = 4;
            // array[4] = 5;
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine(array[i]);
            // }

            // int[] array1 = new int[] { 2, 4, 5, 6, 7, 3, 2 };
            // foreach (int i in array1)
            // {
            //     Console.WriteLine(i);
            // }

            //// 6, 7, 3, 2

            // string[] names = { "vic", "victor", "victoria", "victory" };
            //
            // Console.WriteLine(names[0]);
            // Console.WriteLine(names[1]);
            // Console.WriteLine(names[2]);
            // Console.WriteLine(names[3]);

            //// "vic", "victor", "victoria", "victory"

            // int[] vals = { 1, 2, 3, 4 };
            //
            // vals[0] *= 2;
            // vals[1] *= 2;
            // vals[2] *= 2;
            // vals[3] *= 2;

            // Console.WriteLine(string.Join(",", vals));

            ///// 2, 4, 6, 8

            //int[] cats = new int[4]; // Create an array.
            //cats[0] = 1;
            //cats[1] = 1;
            //cats[2] = 1;
            //cats[3] = 1;



            //// messing around 

            //if (cats != null && cats.Length > 0)
            //{
            //    Console.WriteLine("1");
            //}

            /// //System.Console.WriteLine(test);
            ///
            /// int stor = test[test.Length -2];
            ///
            /// System.Console.WriteLine(stor);

            /// Loop test 

            //string[] planets = { "Mercury", "Venus", "Mars",
            //"Earth", "Jupiter",  "Saturn", "Uranus", "Neptune", "Pluto" };
            //
            //for (int i = 0; i < planets.Length; i++)
            //{
            //    Console.WriteLine(planets[i]);
            //}
            //
            //foreach (string planet in planets)
            //{
            //    Console.WriteLine(planet);
            //}

            //GetStringE   
            ///if (str.Contains(str) && str)
            ///{
            ///    return true;
            ///}
            ///

            // string mix = "cat";
            // Console.WriteLine(mix);
            // if (mix == mix.Replace("cat", ""))
            // {
            //     System.Console.WriteLine("true"); //return true;
            // }
            // System.Console.WriteLine("false");


            //     Console.WriteLine("false"); //return false;
            //Console.WriteLine(name);
            //string index = mix.Remove(0, 1);  // gives me 'at'

            //string start = mix.Substring(0, 2);
            //string start = mix.Substring(0, 2);


            //Console.WriteLine(start);
            //Console.WriteLine(index);
            //
            //if(mix.Substring(0, 2) == "cat" == (mix.Length <= 3))  /// puts 'cat' infront of word
            //{
            //    Console.WriteLine(mix);
            //}
            //
            //if (mix.Length >= 4)
            //{
            // string mix = "cat";
            // string first = mix.Substring(0, 1) + mix.Substring(mix.Length - 3);
            // // if (mix == mix.Replace("c", "") 
            // 
            //         Console.WriteLine(first = mix);




            //if(value.Length <= 3)

            //Console.WriteLine(value + value + value);



            //const string str = "e";
            //foreach (char e in str)
            //{
            //    Console.WriteLine(e);
            //}
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //
            //foreach (char e in str)
            //{
            //  // if (str.Substring(0, 3) == str)
            //        Console.WriteLine("return true");
            //}
            //for (int i = 0; i < str.Length; i++) //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine("return true");//Console.WriteLine(str[i]);
            //}

            //int sum = 0;
            //
            //for (int i = 1; i <= 10; i++)
            //
            //    if ([i] == 'e')
            //        sum + i;
            //Console.WriteLine("sum from 1 to 10 is " + sum);

            ///returns "sum from 1 to 10 is 0"  9 times
            //for (int i = 10 - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // for (int i = 10 - 1; i >= 0; i--)
            // {
            //    Console.WriteLine(i);
            //} 

            // for(char str = 'e'; str <= 'e'; str++)
            // {
            //     Console.WriteLine(str);
            // }
            //
            //for (char e = '0'; e <= '3'; e++)
            //{
            //    Console.WriteLine(e);
            //}

            //    for (int i=0; i < 20; i++)
            //{
            //    if (i == 10)
            //        break;
            //
            //    if (i % 2 == 0)
            //        continue;
            //
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();

            //int str = 0;
            //
            //for (int e = 20; e <= 37; e++)
            //    str += e;
            //Console.WriteLine("solve for 1 and 3 , 'e' " + str);

            /////

            //for (int i = 0, j = 0; i + j <= 5; i++, j++)
            //{
            //    Console.WriteLine("i = {0} and j = {1}", i, j);
            //}

            ///GET BACK 
            ///i = 0 and j=0
            ///i = 1 and j=1...... so on

            //int n = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(n += i);
            //}

            //int N = 0;
            //{
            //   Console.WriteLine(Enumerable.Range(1, N).Sum());
            //}
            /////GET 1 3 6 0; 
            //
            //int N2 = 0;
            //{
            //    Console.WriteLine(N2 * (1 + N2) / 2);
            //}
            /// 1 3 6 0 

            //int S = 0;
            //
            //for (int i = 0; i <= S; i++)
            //{
            // Console.WriteLine(S += i);
            //}

            //int S = 10; 
            //
            //for (int i = 1; i <= S; i++)   ///// gives a range between 1 & 10
            //{
            //    Console.WriteLine("true");//Console.WriteLine(S == i);  // gives a infent loop
            //}
            //Console.WriteLine("true");

            ///***************

            ///program that uses Sum selector
            //var numbers = new double[] { 2.5, 5.0 };
            //// Use ternary in Sum selector.
            //// ... If 2.5, add 100.
            ////     Otherwise add just 1.
            //var result = numbers.Sum(x => x == 2.5 ? 100 : 1);
            //Console.WriteLine(result);

            // Declare two collections of int elements.

            //     string cat = "cats";
            //
            // //int first = cat[0]; // Cats starting at [0]  
            // int last = cat[cat.Length - 1]; // getts last char 
            // int test = cat.ElementAt(0);
            //
            // Console.WriteLine(test);
            //int[] cats = { 1, 3, 5, 7 };
            //
            //int firstin = cats[cats.Length -3];
            //int lastin = cats[cats.Length - 1];
            //
            //Console.WriteLine(firstin);
            //   Console.WriteLine(lastin);

            // Use Sum extension on their elements.

            //int sum1 = array1.Sum();
            ////int sum2 = list1.Sum();
            //
            //if (sum1 == 0)
            //{
            //    Console.WriteLine("true");
            //}

            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);


            //int e = 3; 
            //
            //for (int i = 1; i <= e; i++)
            //{
            //    Console.WriteLine("true");
            //}
            /////// get 1 3 6 true true true;

            //int count = 0;
            ////
            //////https://www.dotnetperls.com/for
            //
            //string input = "tcc";
            //
            //for(int i=0;i<=input.Length-1;i++)
            //{
            //    if(input[i] == 'c')
            //    {
            //        count++;
            //    }
            //}
            //
            //Console.Write("number of c's in input = "+count);
            //Console.Read();
            //
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


        }

    }
    }




