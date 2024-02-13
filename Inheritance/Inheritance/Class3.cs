using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     public class Class3:Class1
    {
        //constructor of class3
        public Class3() {
            Console.WriteLine("Constructor of class3 ");
        }
        static void Main() { 
            Class1 p;//p is a variable of class1
            Class3 c3=  new Class3(); //c3 is instamnce of class3
            p = c3;//p is reference of praent class created by using child class instance.
            //reference will not have any memory allocation -they only consume memory
            p.M1();
            p.M2();
            Console.ReadLine(); 
            
        }
    }
}
