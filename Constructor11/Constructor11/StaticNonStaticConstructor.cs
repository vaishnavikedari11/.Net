using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    internal class StaticNonStaticConstructor
    {
        int x;
        static int y;
        static StaticNonStaticConstructor()
        {
            Console.WriteLine("Static constructor called ");
        }
        public StaticNonStaticConstructor(int x) {
            this.x = x;
            Console.WriteLine("Non-static Constructor is called ");   
        }
        static void Main()
        {
            //main method called after static constructor executed.
            //then inastace of class is created then non-static method will called

            Console.WriteLine("Main method is called");

            //static constructor calling
            Console.WriteLine("static constructor called = "+y);
            //instance of class
            StaticNonStaticConstructor obj1=new StaticNonStaticConstructor(11);
            StaticNonStaticConstructor obj2 = new StaticNonStaticConstructor(22);
            Console.WriteLine("non static constructor called = "+obj1.x + " , " + obj2.x);

            Console.ReadLine();
        }
    }
    
}
