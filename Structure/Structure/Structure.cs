using System;
namespace Strudture
{
    public struct First
    {
        public int i;

        public void Display()
        {
            Console.WriteLine("Method is called in Structure " + i);
        }
        public First(int i) {
            this.i = i;
        }
        static void Main() {
            //without instance creation 
            First f1;
            f1.i = 10;
            f1.Display();
            //with instance creation
            First f2= new First();
            f2.Display();
            //parameterized constructor
            First f3=new First(21);
            f3.Display();
            Console.ReadLine();
            
        }
    }
}