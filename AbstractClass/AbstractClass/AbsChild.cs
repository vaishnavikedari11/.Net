using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
  class AbsChild:AbsParent
    {
        public override void Mult(int x,int y) { 
            Console.WriteLine("Multiplication = " + x * y);
        }
        public override void Div(int x,int y) {
            Console.WriteLine("Division = " + x / y);
        }
        static void Main() { 
            AbsChild a1=new AbsChild();
            a1.Add(12,21);
            a1.Sub(11,2);

            a1.Mult(12,3);
            a1.Div(10,5);

            Console.WriteLine("---------------");

            AbsParent b1 = a1;
            b1.Add(12,21);
            b1.Sub(4,2);
            b1.Mult(2, 3);
            b1.Div(10,5);   


            Console.ReadLine();
        }
    }
}
