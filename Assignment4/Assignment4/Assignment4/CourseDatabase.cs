using System;
using System.Collections.Generic;

namespace Assignment4
{
    public class CourseDatabase
    {
        public List<Course> CourseList = new List<Course>();

        public static void Main(string[] args)
        {
            Console.WriteLine("University Database");

        }

        public void AddCourse(Course course)
        {
            CourseList.Add(course);
        }
        public int CourseCount
        {
            get { return CourseList.Count; }
        }

        public void Display(string param = "all")
        {
            switch (param)
            {
                case "all":
                    foreach (Course course in CourseList)
                    {
                        course.GetSummaryInformation();
                    }
                    break;
                default:
                    bool index = Int32.TryParse(param, out int result);
                        if (!index)
                        {
                            //Error
                        }
                        CourseList[result].GetSummaryInformation();
                    break;
                    
            }
        }
    }
}
