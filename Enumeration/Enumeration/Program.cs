using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    //default value of enum is int
    //enum is value type
        public enum Days
        {
            Monday,Tuesday, Wednesday,Thursday,Friday
                //defaultly enum ranging from 0.
                //but if wee gave any value to that key then it started from that 
                //and then others also follows that range

        }
    public class Program
    {
        //property : meetingdate(meetingdate is only business day)
        public static Days MeetingDate
        {
            //predefined properties
            get;set;
        }=0;


        static void Main(string[] args)
        {
            //class console is a property
            //and ConsoleColor are enum type
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello world");
            //
            Days d=Days.Monday;//this comes under value type
            Days d1 = 0;//its output will be monday .the 0 th value of enum will accepted but othe than 0 enum value doesn't print.
            Days d2 = (Days)2;//we typecast in days for taking output of other keys in enum
            Days d3 = Days.Thursday;//iteger representaion 
            Days d4 = Days.Wednesday;

            Console.WriteLine("******************************************************");
            Console.WriteLine(" d4 "+(int)d4);
            Console.WriteLine("1 st way to print enum = "+d);
            Console.WriteLine("2 nd way to print enum = "+d1);
            Console.WriteLine("3 rd way to print enum = "+d2);
            Console.WriteLine("3 rd way(integerr representaion) to print enum = "+d3);

            //pick all values by using for each loop
            foreach(int i in Enum.GetValues(typeof(Days))){
                Console.WriteLine("Values in Enum = "+i);
            }
            //get names
            foreach (String s in Enum.GetNames(typeof(Days))) { 
                Console.WriteLine("names in enum = "+s);
            }
            //property :MeetingDate
            Console.WriteLine("MeetingDate = "+MeetingDate);
            

            Console.ReadLine();
        }
    }
}
