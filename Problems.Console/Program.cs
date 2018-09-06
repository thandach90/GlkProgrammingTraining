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
            string name = "catapulted";
            string first = name.Substring(0, 1);
            string last = name.Substring(name.Length -1, 1);
            string ochar = name.Substring(name.Length -2, 1);
            string inbetween = name.Substring(1,name.Length -2);
            string fourchar = name.Substring(name.Length );
            System.Console.WriteLine(first);
            System.Console.WriteLine(last);
            System.Console.WriteLine(ochar);
            System.Console.WriteLine(inbetween);
            System.Console.WriteLine(fourchar);

        }

       
    }
}
