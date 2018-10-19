using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class UniversityCourse:Course
    {
        public string CourseSchedule { get; set; }

        public UniversityCourse(string name, string schedule = "daily")
            : base(name)
        {
            CourseSchedule = schedule;
        }

        public override string GetSummaryInformation()
        {
            string info = "";
            info += $"Name: {CourseName}{Environment.NewLine}";
            info += $"Schedule: {CourseSchedule}{Environment.NewLine}";
            return info;
        }


    }
}
