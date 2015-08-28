using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string Name = "John Doe";
        private string StudentID = "Unknown";
        private int YearOfBirth;
        private bool isActive;


        public Student()
        {
            
            YearOfBirth = 2015 - 1995;
            isActive = false;
        }
        public Student(string Name,string StudentID)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            YearOfBirth = 2015 - 1995;
            isActive = true;
        }
        public Student(string Name,string StudentID,int YearOfBirth)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 2015 - YearOfBirth;
            isActive = true;
        }
        public Student(string Name,string StudentID,int YearOfBirth,bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 2015-YearOfBirth;
            isActive = true;
        }
        public  void setAge(int year)
        {
            if (year > 1949)
            {
                
                YearOfBirth = 2015 - year;
            }
            else
            {
                Console.WriteLine(StudentID + ": " + "error try setting invalid year-of-birth value!");
                YearOfBirth = 2015 - 1993;
            }
        }
        public int getAge()
        {
            return 0;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return "";
        }
        public void setID (string id)
        {
            this.StudentID = id;
        }
        public string getID()
        {
            return "";
        }
        public void setActive(bool status)
        {
            isActive = status;

        }
        public bool getActive()
        {
            return true;
        }
        public override string ToString()
        {
            if (isActive == true)
            {
                return "Student : "+ Name + " (" + StudentID + ") " + ", age=" + YearOfBirth + ", is active student";
            }
            else
            {
                return "Student : " + Name + " (" + StudentID + ") " + ", age=" + YearOfBirth + ", is not active student";
            }
        }

    }

}
