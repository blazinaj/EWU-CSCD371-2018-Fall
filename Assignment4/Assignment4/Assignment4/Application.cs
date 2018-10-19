using System;
using System.Collections.Generic;

namespace Assignment4
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Register(object @object)
        {
            if (@object is UniversityCourse course)
            {
                RegisteredPeopleIds.Add(course.Id);
            }
            if (@object is Person person)
            {
                RegisteredPeopleIds.Add(person.id);
            }
            RegisteredPeopleIds.Add(person.Id);
            return RegisteredPeopleIds.Count;

            switch (@object)
            {
                case Person person:
                    RegisteredPeopleIds.Add(person.Id);
                    //POLYMORPHISM. WORKS IF object is an employee or a person
                    break;
                case UniversityCourse course:
                    RegisteredPeopleIds.Add(course.Id);
                    break;
                case null:
                    throw new ArgumentNullException(nameof(object));
                default:
                    throw new ArgumentNullException("Unknown object type", nameof(@object);
            }

        }

        public static List<string> RegisteredPeopleIds { get; }
            = new List<string>();
    }
}
