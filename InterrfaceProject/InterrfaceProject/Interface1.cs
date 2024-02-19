using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterrfaceProject
{
   public interface Interface1
    {
       void Add(int a,int b);
    }
    public interface Interface2 : Interface1
    {
       void Sub(int a,int b);
    }
    public class Interface3 : Interface2
    {
        //while declaring method we make them as public so we use public or Interface name.method name()


        void Interface1.Add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Substraction = " + (a - b));
        }


        static void Main()
        {
            Interface3 i3 = new Interface3();
            //
           // i3.Add(1,2);
            i3.Sub(1,2);
            //
            Interface2 i2 = i3;
            i2.Add(11,22);
            i2.Sub(12,32);

            Console.ReadLine();
        }

    }
}
