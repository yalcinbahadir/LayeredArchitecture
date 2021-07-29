using LA.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DataAccess.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        bool AddStudent(Student entity);
        Student GetStudentByEmail(string email);
        Student GetStudentById(int id);
    }
}
