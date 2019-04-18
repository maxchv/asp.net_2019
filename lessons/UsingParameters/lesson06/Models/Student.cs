using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson06.Models
{
    public class Student
    {
        private static int count;
        public Student()
        {
            Id = ++count;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}