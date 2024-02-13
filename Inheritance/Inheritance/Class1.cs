using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Class1 is parent class of class2
    public class Class1
    {
        //every class contain implicit constructor if not define explicitly
        
        //default scope of members -constructor is private.
        //if we use private constructor then it is not called by class2/child class
       
        // explicit constructor of class 1
        public Class1() {
            Console.WriteLine("Constructor of Class1 -parent class");
        }
        public void M1()
        {
            Console.WriteLine("M1 method  of parent class -class1. ");
        }
        public void M2()
        {
            Console.WriteLine("M2 method of parent classs -class1.");
        }
        
            
        
    }
}
