using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IStudentRepository _students;

        public UnitOfWork(IStudentRepository students)
        {
            _students = students;
        }

        public IStudentRepository StudentRepo => _students;
    }
}
