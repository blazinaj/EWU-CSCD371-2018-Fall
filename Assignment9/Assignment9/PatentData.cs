using System;
using System.Collections.Generic;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10
{
    public class Inventor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{ Name } ({ City }, { State })";
        }
    }

    public static class PatentData
    {
        public static readonly Inventor[] Inventors = new Inventor[]
        {
            new Inventor()
            {
                Name = "Benjamin Franklin",
                City = "Philadelphia",
                State = "PA",
                Country = "USA",
                Id = 1
            },
            new Inventor()
            {
                Name = "Orville Wright",
                City = "Kitty Hawk",
                State = "NC",
                Country = "USA",
                Id = 2
            },
            new Inventor()
            {
                Name = "Wilbur Wright",
                City = "Kitty Hawk",
                State = "NC",
                Country = "USA",
                Id = 3
            },
            new Inventor()
            {
                Name = "Samuel Morse",
                City = "New York",
                State = "NY",
                Country = "USA",
                Id = 4
            },
            new Inventor()
            {
                Name = "George Stephenson",
                City = "Wylam",
                State = "Northumberland",
                Country = "UK",
                Id = 5
            },
            new Inventor()
            {
                Name = "John Michaelis",
                City = "Chicago",
                State = "IL",
                Country = "USA",
                Id = 6
            },
            new Inventor()
            {
                Name = "Mary Phelps Jacob",
                City = "New York",
                State = "NY",
                Country = "USA",
                Id = 7
            },
        };
    }
}
