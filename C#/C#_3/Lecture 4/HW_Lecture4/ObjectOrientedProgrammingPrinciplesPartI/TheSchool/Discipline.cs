using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Discipline : ICommentable
    {
        //Disciplines have name, number of lectures and number of exercises.
      //Students, classes, teachers and disciplines could have optional comments (free text block).
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int NumberOfLectures { get { return this.numberOfLectures; } set { this.numberOfLectures = value; } }
        public int NumberOfExercises { get { return this.numberOfExercises; } set { this.numberOfExercises = value; } }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}