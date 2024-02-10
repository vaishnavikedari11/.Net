using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    
    internal class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor called");
        }
        public static void Main(string[] args) {
            ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor ob2 = new ExplicitConstructor();
            Console.ReadLine();

        }
    }
}
