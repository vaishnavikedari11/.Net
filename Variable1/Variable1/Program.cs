using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable1
{
    internal class Program
    {
        //Static Variable -it has only one copy and can be modified
        static int x=12;
        //instance /non static variable - these have multiple copies and can be modified.
        //for initializing instancre variable we have to create instance of class.
        int y ;
        //constant variable - these have only one copy and can not be modified.
        const bool b = false;
        //readonly variable - these have multiple copies and can not modified.
        readonly char c='a';

        //constructor
        Program(int y) {
            this.y = y;
        }
        static void Main(string[] args)
        {
            //for initializing static variable no need to create any instance
            Console.WriteLine("Static variable value of x = "+x);
            // initializing instance variable
            Program p1=new Program(10);
            Console.WriteLine("Instance variable value of y = "+p1.y);
            //initializing constant variable
            Console.WriteLine("Constant variable value of b = "+b);
            //for initializing readonly variable we have to create instance of class
            Program p2=new Program('h');
            Console.WriteLine("readonly variable value of c = " + p2.c);

            Console.ReadLine();

            
        }
    }
}
