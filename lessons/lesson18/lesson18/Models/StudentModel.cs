using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace lesson18.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual IEnumerable<SubjectMarks> SubjectsMarks { get; set; }
    }

    public class SubjectMarks
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        [DisplayName("Оценка")]
        public int Mark { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        [DisplayName("Название предмета")]
        public string Name { get; set; }

        public virtual IEnumerable<SubjectMarks> SubjectMarks { get; set; }
    }
}
