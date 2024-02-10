using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    internal class ExplicitImplicitConstructors
    {
        public int i;
    }
    class Second
    {
        int i ;

        public Second(int i) {
            this.i = i;
        }
        static void Main(string[] args)
        {
            ExplicitImplicitConstructors obj3= new ExplicitImplicitConstructors();
            ExplicitImplicitConstructors obj4=new ExplicitImplicitConstructors();
            Console.WriteLine("ExplicitImplicitConstructors claa = " + obj3.i+" , "+obj4.i);

            Second obj1 = new Second(10);
            Second obj2 = new Second(20);
            Console.WriteLine("Second class = "+obj1.i+" , " +obj2.i);

            Console.ReadLine();
        }
    }
}
