using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //if its the weekend and its night we want to party. If its not night, we dont want to party but if its the weekend we will still party. If we want to party, return true;

            bool isNight = true;
            bool isWeekend = true;


           
            if (isNight && isWeekend)
            {
                System.Console.WriteLine("We party");
            }
            else if(!isNight || isWeekend)
            {
                
            }
           
            else
            {
                System.Console.WriteLine("We dont party");
            }
            
            

            System.Console.Read();


        }
    }
}
