using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        //set class properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //because test requires min/max Grade, properties must have a conditional statement to manipulate the user's values
        private int grade1;
        public int Grade
        {
            get { return grade1; }
            set
            {
                if (value < 1)
                {
                    grade1 = 1;
                }
                else if (value > 12)
                {
                    grade1 = 12;
                }
                else
                {
                    grade1 = value;
                }
            }
        }

        //because the test requires a min/max for GPA, a conditional statement must be used in order to set min and max values
        private double gpa1;
        public double GPA
        {
            get { return gpa1; }
            set
            {
                if (value < 0)
                {
                    gpa1 = 0;
                }
                else if (value > 4)
                {
                    gpa1 = 4;
                }
                else
                {
                    gpa1 = value;
                }
            }
        }

        //static class method that takes in a list of students and returns a list of student that meet two criteria: 9th grade or above AND GPA 3 or greater
        public static List<Student> StarStudents(List<Student> students)
        {           
            var starStudents = students.Where(p => p.Grade >= 9 && p.GPA >= 3); //Linq method using Where, two conditional statements must be met   
            var orderedStarStudents = starStudents.OrderByDescending(p => p.Grade) //Linq method for sorting OrderByDescending
                .ThenByDescending(p => p.GPA) //Linq method for the next sorting ThenByDescending
                .ThenBy(p => p.LastName) //Linq method ThenBy
                .ThenBy(p => p.FirstName); //Linq method ThenBy
            return orderedStarStudents.ToList();
        }
    }
}
