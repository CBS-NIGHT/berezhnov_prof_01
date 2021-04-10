using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Month
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Days { get; set; }

        public Month(string name, int number, int days)
        {
            Name = name;
            Number = number;
            Days = days;
        }
    }
}
