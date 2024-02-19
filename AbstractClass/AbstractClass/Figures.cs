using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Figures
    {
        public double Height, Width;
        public float Radius,Pi = 3.14f;

        //abstract method
        public abstract double GetArea();
    }
    public class Rectangle:Figures { 
        public Rectangle(double Height,double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double GetArea()
        {
            return Height* Width;
        }
    }

    public class Circle : Figures
    {
        public Circle(float Radius ) {
            this.Radius = Radius;
            this.Pi = Pi;
        }

        public override double GetArea()
        {
            return Radius*Radius*Pi;
        }
    }
    public class Cone : Figures
    {
        public Cone(float Radius,double Height) {
            this.Radius = Radius;
            this.Pi = Pi;
        }
        public override double GetArea()
        {
            return Pi*Radius*(Radius+Math.Sqrt(Height*Height+Radius*Radius));
        }
    }

    public class Test { 
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(11,22);
            Circle c = new Circle(3);
            Cone cn = new Cone(11,2);

            Console.WriteLine("Area of Rectangle = "+r.GetArea());
            Console.WriteLine("Area of Circle = " + c.GetArea());
            Console.WriteLine("Area of Cone = " + cn.GetArea());

            Console.ReadLine();
        }
    }
}
