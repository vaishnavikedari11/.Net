using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class OperatorOverloading
    {
    }
    class Matrix {
        int a, b, c, d;

        //constructor 
        Matrix(int a, int b, int c, int d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString()
        {
            return a+ " "+b+"\n"+c+ " "+d+"\n";
        }
        //method
        public static Matrix operator +(Matrix obj1,Matrix obj2){
            Matrix obj = new Matrix(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;
        }

        static void Main() { 
            Matrix m1=new Matrix(11,12,13,13);
            Matrix m2 = new Matrix(1,2,3,4);
            Matrix m3 = m1 + m2;
            //if we call m3 then it will written classname
            //after writing toString method  m3 will print the matrix.
            Console.WriteLine(m3);
            Console.ReadLine();

        }
    }
}
