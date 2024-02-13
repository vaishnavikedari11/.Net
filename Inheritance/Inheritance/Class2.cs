using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Class2 is child class of class1
    public class Class2:Class1
    {
        //implicit constructor /not defined constructor of child class
        //child class constructor implicitly called parent class constructor
        
        //explicit constructor of class2
        public Class2() {
            Console.WriteLine("Constructor of Class2 -child class");
        }
        public void M3() {
            Console.WriteLine("M3 method of child class-class2");
        }
        
        static void  Main()
        {
            Class2 obj1 = new Class2();
            //parent class method calling
            obj1.M1();
            obj1.M2();
            //child class method calling
            obj1.M3();
            Console.ReadLine();
        }
    }
}
