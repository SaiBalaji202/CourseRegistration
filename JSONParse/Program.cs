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
            course1.SaveToFile();
            var course2 = new Course("Node", "ji");
            course2.SaveToFile();

            var student1 = new Student()
            {
                Name = "Sai",
                Email = "sai@gmail.com",
                IntrestedSubjects = new List<string>() { "Node", "Angular" },
                Courses = new List<Course>() { course1, course2 }
            };

            var student2 = new Student()
            {
                Name = "Raj",
                Email = "ra,@gmail.com",
                IntrestedSubjects = new List<string>() { "Node", "C" },
                Courses = new List<Course>() { course1 }
            };
            student2.SaveToFile();
            //
            //            Console.WriteLine(student1);
            //            Console.WriteLine(student2);
            var sai = Student.LoadFromFile("Sai");
            Console.WriteLine(sai);
            var ram = Student.LoadFromFile("Ram");
            Console.WriteLine(ram);
            var raj = Student.LoadFromFile("Raj");
            Console.WriteLine(raj);
        }
    }
}
