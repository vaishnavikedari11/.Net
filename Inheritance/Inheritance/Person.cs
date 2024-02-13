using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    public class Person
    {
        public int Id, Phone;
        public String Name, Address;

      
        static void Main()
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "Person1";
            p.Phone = 12234313;
            p.Address = "At/p XYZ";
            Student s1=new Student();
            Console.WriteLine(s1.Id  + s1.Name + s1.Address  + s1.Phone  + s1.Classroom + s1.Marks+s1.Grade+s1.Fees);
            Console.ReadLine();
        }
    }
    public class Student : Person
    {
        public int Marks;
        public int Classroom;
        public char Grade;
        public int Fees;
    }
    public class Staff : Person
    {
        public int Designation;
        public int Sallary;
    }
    public class Teaching : Staff
    {
        public String Qualification;
        public String Subject;
    }
    public class NonTeaching:Staff{
        public String Department;

    }
}
