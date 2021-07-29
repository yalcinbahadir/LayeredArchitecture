using LA.DataAccess.Repositories;
using LA.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Services.Services
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool AddStudent(Student entity)
        {
            return unitOfWork.StudentRepo.AddStudent(entity);            
        }

        public Student GetStudentByEmail(string email)
        {
            return unitOfWork.StudentRepo.GetStudentByEmail(email);
        }

        public Student GetStudentById(int id)
        {
            return unitOfWork.StudentRepo.GetStudentById(id);
        }

        public List<Student> GetStudents()
        {
            return unitOfWork.StudentRepo.GetStudents();
        }
    }
}
