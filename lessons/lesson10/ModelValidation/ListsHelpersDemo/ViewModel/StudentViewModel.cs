using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListsHelpersDemo.Models;

namespace ListsHelpersDemo.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        public Student Student => new Student
        {
            Id = Id,
            Name = Name,
            Age = Age,
            Group = Academy.Instance.Groups.FirstOrDefault(g => g.Id == GroupId)
        };
    }
}