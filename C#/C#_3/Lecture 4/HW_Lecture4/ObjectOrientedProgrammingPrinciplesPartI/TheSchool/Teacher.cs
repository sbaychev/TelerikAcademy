using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Teacher : Human
    {
        //Each teacher teaches a set of disciplines.Teachers have name.
        //Students, classes, teachers and disciplines could have optional comments (free text block).
        public List<Discipline> Discplines { get; set; }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.Discplines = new List<Discipline>();
        }
        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }   
}