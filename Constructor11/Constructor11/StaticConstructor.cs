using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    internal class StaticConstructor
    {
        static int x = 17;
        //static constructor
        static StaticConstructor() { //it will called implicitly called -so we can not provide parameters-so overloading of static constructor is not possible
            Console.WriteLine("static constructor is called");
            Console.WriteLine("value of x = " + x);
        }
        static void Main(string[] args)
        {
            //StaticConstructor obj1= new StaticConstructor();
            Console.WriteLine("Main method is called");//this executed after the static constructor called.
            Console.ReadLine();
        }
    }
}
