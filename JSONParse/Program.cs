using System;
using System.Collections.Generic;

namespace JSONParse
{
    class Program
    {
        /*
         * Student
         * Courses
         * 
         * */


        static void Main(string[] args)
        {
            var course1 = new Course("JSON", "Balaji");
            var course2 = new Course("Node", "ji");


            var student1 = new Student()
            {
                Name = "Sai",
                Email = "sai@gmail.com",
                IntrestedSubjects = new List<string>() { "Node", "Angular" },
                Courses = new List<Course>() { course1, course2 }
            };

            var student2 = new Student()
            {
                Name = "Ram",
                Email = "ra,@gmail.com",
                IntrestedSubjects = new List<string>() { "Node", "C" },
                Courses = new List<Course>() { course1 }
            };

            Console.WriteLine(student1);
            Console.WriteLine(student2);

        }
    }
}
