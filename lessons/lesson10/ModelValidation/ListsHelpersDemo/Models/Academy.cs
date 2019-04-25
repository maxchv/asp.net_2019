using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListsHelpersDemo.Models
{
    public class Academy
    {
        public List<Group> Groups { get; } = new List<Group>();
        public List<Student> Students { get; } = new List<Student>();
        private static Academy _instance = new Academy();
        public static Academy Instance => _instance;

        private Academy()
        {
            Groups.Add(new Group{Id = 1, Name = "ЕКО 15-П-1"});
            Groups.Add(new Group { Id = 2, Name = "ЕКО 16-П-1" });
            Groups.Add(new Group { Id = 3, Name = "СПУ 16-О-1" });
        }

        public void Save(Student student)
        {
            var maxId = Students.Count == 0 ? 0 : Students.Max(s => s.Id);
            if (student.Id == 0) student.Id = maxId + 1;
            Students.Add(student);
        }
    }
}