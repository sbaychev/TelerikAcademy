using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            //the same as Task3, we are just modifying the LINQ querry
            Student[] students = 
            {
               new Student("Pesho", "Petrov", 23),  
               new Student("Pesho", "Grigorov", 44),  
               new Student("Pesho", "Trifonov", 25),  
               new Student("Pesho", "Angelov", 33),
               new Student("Pesho", "Zarev", 20),  
            };

            var ageSortStudents =
                from student in students
                where student.Age > 18 && student.Age < 24
                select student;

            foreach (var student in ageSortStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
