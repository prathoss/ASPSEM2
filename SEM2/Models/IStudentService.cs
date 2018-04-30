using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEM2.Models
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
    }
}
