using LA.Domein;
using LA.Services.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LA.UI.Pages.Students
{
    public partial class Create
    {
        public Student Model { get; set; } = new Student();
        [Inject]
        public IStudentService StudentService { get; set; }
        [Inject]
        public NavigationManager Navigator { get; set; }
        private void HandelValidSubmit()
        {
            StudentService.AddStudent(Model);
            Navigator.NavigateTo("students/index");
        }
    }
}
