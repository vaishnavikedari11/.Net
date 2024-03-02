using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Program
    {
        //1 - if we make variable as private so we can not access it by creating instace of class
        //while we create instance it will allocate memory  but we cann not accesss it outside of that class.
        double Radius = 12.34;//by default scope of variable is private
                              //2 - if we want to access that priavte variable then---- make variable as public then we 
        public double Radius1 = 12.34;
        //- if we make va=riable as public then it can accessible by all
        // so avoiding them we have to make variable as private .now for accessing this priavte variable 
        //3 - we can use getting and setting methods.

        public double GetRadius()  //this provides get access only to the value
        {
            return Radius1;
        }

        public void SetRadius(double Radius1) //this provides only set access to the value
        { 
            this.Radius1 = Radius1;
        }
        //but  4 -  if we want to access one method i.e., get or set we have to make variable as priavte
        public double RadiusProperty
        {
            get { return Radius; } //this provides only read  value proprty
            set { Radius = value; } //this provides both read and write properties
        }
    }

        public class TestCircle
        {
            static void Main(string[] args)
            {
                Program p1=new Program();//instance of class
                                         // p1.Radius;not accessible
               //2 nd step ---
                double Radius1 = p1.Radius1;  //getting the old value
                p1.Radius1 = 45.34;      //setting the new value
               //3 rd step---
            p1.GetRadius();
            p1.SetRadius(23.42);
            // 4th step ---
            Console.WriteLine( p1.RadiusProperty);
            p1.RadiusProperty = 12.34;
            Console.WriteLine( p1.RadiusProperty);
            Console.ReadLine();
            
            }
        }
    
}
