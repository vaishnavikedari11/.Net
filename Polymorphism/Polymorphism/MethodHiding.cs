using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //method hiding/Shadowing=Its an approach  of re-implementing parent class methods under child class exactly with the same name and signature.
    public class MethodHiding
    {
        //method overriding 
        public virtual void Test1() {       //overidable
            Console.WriteLine("ParentClass method Test1() called");
        }
        public void Test2() {
            Console.WriteLine("ParentClass method Test2() called");
        }
    }
    public class ChildClass : MethodHiding
    {
        public override void Test1()      //overriding
        {
            Console.WriteLine("ChildClass method Test1() called");
        }
        public new void Test2()      //method hiding/shadowing
        {
            Console.WriteLine("ChildClass method Test2() called");
        }
        public void Test()
        {
             base.Test1();//this will call PrentClass Method.
        
        }
        static void Main() {

            ChildClass c=new ChildClass(); //c is instance of ChildClass
            //by using Child class instance we can call ParentClass methods but
            //we can't call ChildClass methods
            MethodHiding p = c; //p is reference of ParentClass
            p.Test1();//This is PrentClass Test1() method call
            p.Test2();//this is ParentClass Test2() method call
            
            c.Test1();//ChildCLass Test1() method call
            c.Test2();//ChildClass Test2() method call

            Console.ReadLine();
        }
    }
}
