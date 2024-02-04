using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    internal class Program
    {
        int i;
        string s;
        bool b;
        public Program()//Implicitly defined constructor= Default constructor= parameter less constructor
        {
            i = 0;
            s = null;
            b= false;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Console.WriteLine("implicit Constructor is called..");
            Console.WriteLine(obj1.i);
            Console.WriteLine(obj1.s);
            Console.WriteLine(obj1.b);
            Console.ReadLine();
        }
    }
}
