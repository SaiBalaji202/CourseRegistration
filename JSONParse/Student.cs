using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> IntrestedSubjects { get; set; }
        public List<Course> Courses { get; set; }

        public void SaveToFile()
        {
            if (!Directory.Exists("Students"))
            {
                Directory.CreateDirectory("Students");
            }
            var jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText($"Students/{this.Name}.json", jsonData);
            //Students/Sai.json
        }

        public static Student LoadFromFile(string strName)
        {
            if (!File.Exists($"Students/{strName}.json"))
                return null;
            var jsonData = File.ReadAllText($"Students/{strName}.json");
            return JsonConvert.DeserializeObject<Student>(jsonData);
        }

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