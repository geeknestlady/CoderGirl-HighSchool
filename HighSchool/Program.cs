using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
               new Student(){FirstName = "Gipsy", LastName = "Heyen", GPA = 3, Grade = 9 },
               new Student(){FirstName = "Dexter", LastName = "Mullins", GPA = 3.5, Grade = 10 },
               new Student(){FirstName = "August", LastName = "Heyen", GPA = 3.4, Grade = 9 },
               new Student(){FirstName = "Sam", LastName = "Winchester", GPA = 4, Grade = 12 },
               new Student(){FirstName = "Dean", LastName = "Winchester", GPA = 2.5, Grade = 12 },
               new Student(){FirstName = "Bobby", LastName = "Singer", GPA = 3, Grade = 12 },
               new Student(){FirstName = "Castiel", LastName ="Angel", GPA = 4, Grade = 11 },
            };

            List<Student> starStudents = Student.StarStudents(students);

            foreach (Student student in starStudents)
            {
                Console.WriteLine("{0} {1} {2} {3}", student.FirstName, student.LastName, student.Grade, student.GPA);
            }
            Console.ReadLine();
        }
    }
}
