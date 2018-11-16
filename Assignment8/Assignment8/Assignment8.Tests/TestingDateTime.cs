using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8.Tests
{
    class TestingDateTime : IDateTime
    {
        private DateTime Time { get; set; }

        public DateTime testableDateTime()
        {
            return DateTime.Now;
        }
    }
}
