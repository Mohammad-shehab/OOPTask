using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP.Models
{



    // Student class
    public class Student
    {

        public double gpa;
        public string name;
        public int major;


        public  string student(string name, double gpa, string major)
        {

            return $"Hello {name} your GPA is: {gpa}, Major: {major}. ";
        }

    }
    //bonus
    // using inheritance 
    public class GraduateStudent : Student
    {
        public string year;
        public string student(string name, double gpa, string major, string year)
        {
            return $"Hello {name} your GPA is: {gpa}, Major: {major}, Year: {year}. ";
        }
    }


}

