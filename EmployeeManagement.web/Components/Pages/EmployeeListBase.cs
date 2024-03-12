using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.web.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
           await Task.Run( LoadEmployees);
            
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
               
                EmployeeId = 1,
                FirstName = "Manideep",
                LastName = "Nampally",
                Email="manideep.n15@gmail.com",
                DateOfBirth=new DateTime(1995,06,06),
                Gender=Gender.Male,
                Department=new Department { DepartmentId=1,DepartmentName="IT"},
                PhotoPath="images/mani.jpg"
               
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Mani",
                LastName = "Deep",
                Email = "manideep@gmail.com",
                DateOfBirth = new DateTime(1994, 10, 15),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "Health" },
                PhotoPath = "images/Deep.jpg"

            };
        }
    }
}
