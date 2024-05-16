using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKnowledgeCheck2
{
    public class Student
    {
        public string studentName { get; set; }
        public int studentAge { get; set; }
        public List<string> studentCourses { get; set; }
        public string studentMomName { get; set; }
        public string studentDadName { get; set; }
        public Student()
        {
            studentCourses = new List<string>();
        }
        public override string ToString()
        {
            var coursesString = studentCourses.Any() ? string.Join(", ", studentCourses) : "No courses listed";
            return $"Name: {studentName}, Age: {studentAge}, Courses: {coursesString}, Mom's Name: {studentMomName}, Dad's Name: {studentDadName}";
        }
    }
}
