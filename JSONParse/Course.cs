using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JSONParse
{
    class Course
    {
        public string CourseName { get; set; }

        public string Instructor { get; set; }

        public Course(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public void SaveToFile()
        {
            // Courses/courses.json
            if (!Directory.Exists("Courses"))
            {
                Directory.CreateDirectory("Courses");
                File.WriteAllText("Courses/courses.json", "[]");
            }

            // 1. Read all Courses from courses.json to a list
            var jsonString = File.ReadAllText("Courses/courses.json");
            var courseList = JsonConvert.DeserializeObject<List<Course>>(jsonString);

            // 2. Add Current Course to that list
            courseList.Add(this);
            // 3. Save the resultant list back to the courses.json
            File.WriteAllText("Courses/courses.json", JsonConvert.SerializeObject(courseList, Formatting.Indented));
        }

        public override string ToString()
        {
            //If you have C# version < 6.0, then replace the following string interpolation with string.Format()
            return $"Course Name: {this.CourseName}\nInstructor: {this.Instructor}";
        }

        /*
         * [
         * {
         *  "CourseName": "JSON", 
         *  "Instructor": "Balaji"
         * }, 
         * * {
         *  "CourseName": "C#", 
         *  "Instructor": "Ji"
         * }, 
         * ]
         */
    }
}