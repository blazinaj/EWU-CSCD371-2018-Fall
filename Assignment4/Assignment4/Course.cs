using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Course
    {
        public Type CourseType { get; set; }

        public string CourseName { get; set; }

        public Course(string name)
        {
            CourseName = name;
        }

     
        public virtual string GetSummaryInformation()
        {
            string info = "No information available";
            return info;
        }


    }
}
