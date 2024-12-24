//task OOP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP.Models;




Console.WriteLine("Name: ");
string name = Console.ReadLine();
Console.WriteLine("GPA: ");
double gpa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Major: ");
string major = Console.ReadLine();

////////////////////////////////////////////////////////////////////

Student stu = new Student();
Console.WriteLine(stu.student(name, gpa, major));

////////////////////////////////////////////////////////////////////


Console.WriteLine("Year: ");
string year = Console.ReadLine();

GraduateStudent und = new GraduateStudent();
Console.WriteLine(und.student(name, gpa, major, year));
