using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbsParent
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Addition = "+x+y);
        }
        public void Sub(int x ,int y) {
            Console.WriteLine("substraction = "+(x-y));
        }
        public abstract void Mult(int x,int y);
        public abstract void Div(int x,int y);
    }
        
    
}
