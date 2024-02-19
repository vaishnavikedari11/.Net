using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterrfaceProject
{
    public interface Interface5
    {
        void Test();
        void Show();
    }
    public interface Interface6:Interface5
    {
        void Test();
        void Show();
    }

    public class MyClass : Interface5, Interface6
    {
        //1st way of defining method
        public void Test() {
            Console.WriteLine("Test() is called ");
        }
        //2nd way of defining method
        void Interface5.Show() 
        {
            Console.WriteLine("Show() is called by using Interface5");
        }

        void Interface6.Show() {
            Console.WriteLine("Show() is called by using Interface6");
        }

        static void Main()
        {
            MyClass m1=new MyClass();
            m1.Test();
            //if we have to call show() that particular class then we call only by using that class referenvce
            Interface5 i1 = m1;
            i1.Show();

            Interface6 i2 = m1;
            i2.Show();

            Console.ReadLine();
        }
    }
}
