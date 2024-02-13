using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //overloadong=it is an approach  which defining a method with multiple behaviour.
    public class MethodOverloading
    {
        //method with no paramter
        public void M1() {
            Console.WriteLine("M1  method is called" );
        }
        //method with one parameter
        public void M2(int n1)
        {
            Console.WriteLine("M2 method is called");
        }
        //method with two parameter
        public void M3(int n2,int n3)
        {
            Console.WriteLine("M3 method is called");
        }
        //method with different parameter type
        public void M4(String s1) {
            Console.WriteLine("M4 method is called");
        }
        //method with two different type of parameters
        public void M5(int n4,String s2)
        {
            Console.WriteLine("M5 method is called");
        }
        static void Main(string[] args)
        {
            MethodOverloading p1=new MethodOverloading(); 
            p1.M1();
            p1.M2(10);
            p1.M3(10,20);
            p1.M4("Vaishnavi");
            p1.M5(1,"XYZ");

            Console.ReadLine();
        }
    }
}
