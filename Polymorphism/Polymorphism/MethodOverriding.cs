using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//polymorphism-it is mechanism of changing the behaviour of input that is,
//input chaneges automatically the behavoiur of input changes.
namespace Polymorphism
{
//overriding=it is an approach of re-implementing parent class method under child classs with the same pameters.
  public class MethodOverriding
    { 

    }
    //Parent class
    public class Parent
    {

        public void Show() {
            Console.WriteLine("Parent class Show() method is called");
        }

        public virtual void Test() { //overridable (using virtual modifier)
            Console.WriteLine("Parenet class Test() method is called");
        }
    }
    //Child Class
    public class Child : Parent
    {
        //overloadong parent class Show() method
        public void Show(int i) {
            Console.WriteLine("Child class Show() method is called");
        }

        //overriding parents class Test()
        public override void Test() {  //overriden (using override modifier)
            Console.WriteLine("Child class Test() method is called");
        }


        static void Main(string[] args)
        {
            Child c=new Child();
            c.Show();  //child class Show () method
            c.Test();  //child class Test() method
           // c.Show(10); //Parent class Show() method
           c.Show(10);
           // c.Test();
            
            Console.ReadLine();
        }
    }
}
