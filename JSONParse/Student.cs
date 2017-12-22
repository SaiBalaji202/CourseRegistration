using System;
using System.Collections.Generic;

namespace JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> IntrestedSubjects { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            //If you have C# version < 6.0, then replace the following string interpolation with string.Format()
            return $"********************************************\n\tDetails of {this.Name}\n********************************************\n" +
                   $"Name: {this.Name}\nEmail: {this.Email}\n" +
                   $"Intrested Subjects: {String.Join(", ", this.IntrestedSubjects)}\nRegistered Courses: " +
                   $"{String.Join(", ", this.Courses)}";
        }
    }
}