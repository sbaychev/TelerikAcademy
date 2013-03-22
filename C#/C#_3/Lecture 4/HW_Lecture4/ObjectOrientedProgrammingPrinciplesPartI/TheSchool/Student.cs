using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Student : Human
    {   //Students, classes, teachers and disciplines could have optional comments (free text block).Students have name and unique class number.
        private int classNumber;


        // Task 2 of the Homework for the new class Student is commented bellow
        //private int grade;

        //public Student(string fName, string lName, int grade)
        //    : base(fName, lName)
        //{
        //    this.grade = grade;
        //}

        //public int Grade
        //{
        //    get { return this.grade; }
        //    set { this.grade = value; }
        //}

        public List<string> Comments { get; set; }
        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }
        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.classNumber = classNumber;
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
        public override string ToString()
        {
            string result = string.Format("Student Name: {0} {1}", this.firstName, this.lastName);
            //for Task 2 of the HW bellow
            //string result = string.Format("Student Name: {0} {1}    Grade: {2}", this.firstName, this.lastName, this.grade);
            return result;
        }
    }
}