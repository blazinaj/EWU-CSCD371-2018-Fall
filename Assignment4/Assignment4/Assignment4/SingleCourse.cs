using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class SingleCourse : Course
    {
        public DateTime Date { get; set; }

        public SingleCourse(string name)
            : base(name)
        {
            Date = DateTime.Today;
        }

        public SingleCourse(string name, DateTime date)
            : base(name)
        {
            Date = date;
        }


        public override string GetSummaryInformation()
        {
            string info = "";
            info += $"Name: {CourseName}{Environment.NewLine}";
            info += $"Date: {Date}{Environment.NewLine}";
            return info;
        }
    }
}
