using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        string name;
        string courseID;
        string lecturer;
        int maxStudents;
        int numStudents;

        public Course()
        {
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string Name, string CourseID)
        {
            this.name = Name;
            this.courseID = CourseID;
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;

        }
        public Course(string Name, string CourseID, string Lecturer)
        {
            this.name = Name;
            this.courseID = CourseID;
            this.lecturer = Lecturer;
            maxStudents = 30;
            numStudents = 0;

        }
        public Course(string Name, string CourseID, string Lecturer, int MaxStudents)
        {
            this.name = Name;
            this.courseID = CourseID;
            this.lecturer = Lecturer;
            this.maxStudents = MaxStudents;
            numStudents = 0;

        }
        public int NumStudents
        {
            get
            {
                return numStudents;
            }
            set
            {
                if (value > this.maxStudents || value < 0)
                {
                    Console.WriteLine(this.courseID + ": error try setting invalid No. Students!");
                }
                else
                {
                    numStudents = value;
                }
            }
        }
           
        public int MaxStudents
        {
            
            get
            {
                return maxStudents;
            }
            set
            {
                if (value > 80 || value < this.numStudents)
                {
                    Console.WriteLine(this.CourseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    maxStudents = value;
                }
            }

        }
        public string CourseID
        {

            get
            {
                return courseID;
            }
            set
            {
                int number;
                bool check = int.TryParse(value, out number);
                if (value.Length != 6 || check == false)
                {
                    Console.WriteLine(this.courseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    courseID = value;
                }
            }

        }
        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string ToString()
        {
         
           return "Course:"+ Name+  "(" + CourseID + "), Lecturer=" + Lecturer + " , has " + NumStudents + " students, max="+ MaxStudents;
    
        }
    }
}
