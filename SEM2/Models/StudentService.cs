using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEM2.Models
{
    public class StudentService : IStudentService
    {
        public StudentService() : base()
        {
        }

        Dictionary<int, Student> Students = new Dictionary<int, Student>()
        {
            { 1, new Student{Id = 1, Name = "A", LastName = "B", Birthday = new DateTime(1996, 1, 1) } },
            { 2, new Student{Id = 2, Name = "C", LastName = "D", Birthday = new DateTime(1995, 1, 1) } },
            { 3, new Student{Id = 3, Name = "E", LastName = "F", Birthday = new DateTime(1994, 1, 1) } }
        };

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            foreach(KeyValuePair<int, Student> kvp in Students)
            {
                students.Add(kvp.Value);
            }
            return students;
        }

        public Student GetById(int id)
        {
            return Students[id];
        }
    }
}
