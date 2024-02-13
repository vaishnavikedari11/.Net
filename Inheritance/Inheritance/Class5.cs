using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Class5:Class4
    {

        public Class5() : base(10)
        {
            Console.WriteLine("Class5 constructor-child class");
        }

        public Class5(int a):base(a) {
            Console.WriteLine("Class5 constructor-child class");
        }
        static void Main() { 
            //Object is base class of all classes
            Object obj=new Object();
            Console.WriteLine(obj.GetType());
           // Class4 p=new Class4();
           // Console.WriteLine(p.GetType());
            Class5 c = new Class5(50);
            Console.WriteLine(c.GetType());
            Console.ReadLine();
        }
    }
}
