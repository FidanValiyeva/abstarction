using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class Student
    {
        public double Id;
        public string FullName;
        public double Point;

        public Student(double id, string fullName, double point)
        {
            Id=id;  
            FullName=fullName;
            Point=point;
        }

        

        public void StudentInfo()
        {
            Console.WriteLine($"Id:{Id},FullName{FullName},Point:{Point}");
        }



    }
}
