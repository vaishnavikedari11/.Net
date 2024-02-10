using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor11
{
    internal class ParameterizedConstructror
    {
        int i;
        int b;

        public ParameterizedConstructror(int i, int b) {
            Console.WriteLine("paramerized constructor called ,value of i =" + i +" b is = "+ b);
        }
        static void Main(string[] args)
        {
            ParameterizedConstructror ob1 = new ParameterizedConstructror(1,12);
            
            Console.ReadLine();

        }
    }
}
