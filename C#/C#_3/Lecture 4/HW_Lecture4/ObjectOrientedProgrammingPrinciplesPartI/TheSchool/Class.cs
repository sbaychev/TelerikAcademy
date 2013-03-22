using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Class
    {
        //In the school there are classes of students. Each class has a set of teachers. Classes have unique text identifier.
        //Students, classes, teachers and disciplines could have optional comments (free text block).
        private string classID;

        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<string> Comments { get; set; }
        public string ClassID { get { return this.classID; } set { this.classID = value; } }

        public Class(string classID)
        {
            this.ClassID = classID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();          
        }
        public Class(string classID, List<Student> student, List<Teacher> teacher)
        {
            this.ClassID = classID;
            this.students = student;
            this.teachers = teacher;
        }
    

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
        
    }   
}
