using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class Group
    {
        double GroupNo;
        double StudentLimit;

        public Group(double groupNo, Double studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Student[] Students = new Student[0];


        }
        private double studentLimit
        {
            get
            {
                return studentLimit;
            }

            set
            {
                if (studentLimit >= 5 && studentLimit <= 18)

                {
                    studentLimit = value;
                }


            }
        }

        public void CheckGroupNo(string groupNo)
        {
            if (groupNo == null)
            {
                Console.WriteLine(true);
                return;
            }
            else
            {
                Console.WriteLine(false);
                return;
            }

        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref student, student.Length - 1);
            student[student.Length - 1] = student;
        } 
        public void GetStudent()
        {

        }

        public void GetAllStudents()
        {
            Console.WriteLine("Hal-hazırda olan tələbələr:");
        }





    
    }
}
