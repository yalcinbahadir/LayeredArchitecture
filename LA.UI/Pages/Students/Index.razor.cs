using LA.Domein;
using LA.Services.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.UI.Pages.Students
{
    public partial class Index
    {
        public List<Student> Students { get; set; } = new List<Student>();
        [Inject]
        public IStudentService StudentService { get; set; }
        protected override void OnInitialized()
        {
            Students = StudentService.GetStudents();
            base.OnInitialized();
        }
    }
}
