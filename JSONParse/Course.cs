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