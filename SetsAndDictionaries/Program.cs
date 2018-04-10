using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndDictionaries
{
    //START UP OBJECT MUST BE SET TO DESIRED MAIN METHOD (PROGRAM OR PROGRAM2)
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>
            //HashSet<Student> students = new HashSet<Student>(new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 },
            };

            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };

            students.Add(joe);

            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(duplicateJoe);

            if (students.Contains(joe)) { }  //check if it's in the collection    hashset.contains is faster than list.contains

            Console.WriteLine(joe.GetHashCode());
            Console.WriteLine(duplicateJoe.GetHashCode());

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
            Console.ReadLine();
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {

        }
    }
}
