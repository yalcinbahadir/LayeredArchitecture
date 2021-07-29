using LA.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DataAccess.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(Student entity)
        {
            _context.Students.Add(entity);
            return _context.SaveChanges() > 0;
           
        }

        public Student GetStudentByEmail(string email)
        {
           return _context.Students.FirstOrDefault(s=>s.Email==email);
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
