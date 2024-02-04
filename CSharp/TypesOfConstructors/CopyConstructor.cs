using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{

    internal class CopyConstructor
    {
        int x;
        public CopyConstructor(int i) {
           x = i;
        }
        //copy constructor -
        public CopyConstructor(CopyConstructor obj1 ) { //here CopyConstructor is new data-type
            x=obj1.x;   //x is lical variable
        }
        public void display()
        {
            Console.WriteLine("Value of x = "+x);
        }
        static void Main(string[] args)
        {
            CopyConstructor obj1=new CopyConstructor(1);
            obj1.display();
            CopyConstructor obj2=new CopyConstructor(obj1);
            obj2.display();

            Console.ReadLine();
        }
    }
}
