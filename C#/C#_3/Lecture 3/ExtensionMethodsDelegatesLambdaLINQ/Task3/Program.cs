using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that from a given array of students finds all students whose first name 
            //is before its last name alphabetically. Use LINQ query operators.
            Student[] students = 
            {
               new Student("Pesho", "Petrov"),  
               new Student("Pesho", "Grigorov"),  
               new Student("Pesho", "Trifonov"),  
               new Student("Pesho", "Angelov"),
               new Student("Pesho", "Zarev"),  
            };

            var alphSortStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1//legicographically before the firstName
                select student;

            foreach (var student in alphSortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}