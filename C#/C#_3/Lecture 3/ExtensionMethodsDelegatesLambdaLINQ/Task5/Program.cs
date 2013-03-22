using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last 
            //name in descending order. Rewrite the same with LINQ.
            Student[] students = 
            {
               new Student("Pesho", "Petrov", 23),  
               new Student("Pesho", "Grigorov", 44),  
               new Student("Pesho", "Trifonov", 25),  
               new Student("Pesho", "Angelov", 33),
               new Student("Pesho", "Zarev", 20),  
            };
            //lambda expressions sort the students by first name and last name in descending order

            var descSortStudents =
                 from student in students
                 orderby student.FirstName descending, student.LastName descending
                 select student;

            //LINQ sort the students by first name and last name in descending order

            //var descSortStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var student in descSortStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}