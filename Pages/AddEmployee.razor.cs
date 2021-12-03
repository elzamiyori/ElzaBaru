using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components;
using BlazorFront.Models;

namespace ElzaBaru.Pages
{
    public partial class AddEmployee
    {
        
        public Employee Employee { get; set; } = new Employee();

        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        [Parameter]
        public string Id { get; set; }

        protected  async override  Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetById(int.Parse(Id));
            Departments = (await DepartmentService.GetAll()).ToList();
        }
        protected async Task HandleValidSubmit()
        {
            Employee.PhotoPath = "images/mau.jpg";
            Employee.PhotoPath = "images/nion.jpg";
            var result = await EmployeeService.Update(int.Parse(Id),Employee);
            NavigationManager.NavigateTo("employeepage");
        }
    }
}