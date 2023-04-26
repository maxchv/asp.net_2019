using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lesson06.Models;

namespace lesson06.Repository
{
    public class StudentRepository: IRepository<Student, int>
    {
        private static List<Student> _students = new List<Student>();

        public StudentRepository()
        {
            _students.Add(new Student{Name="Вася", Age = 25});
        }

        public void Save(Student data)
        {
            _students.Add(data);
        }

        public void Delete(Student data)
        {
            _students.Remove(data);
        }

        public IEnumerable<Student> FindAll()
        {
            return _students;
        }

        public Student FindById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }
}