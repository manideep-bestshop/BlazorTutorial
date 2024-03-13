using EmployeeManagement.Models;

namespace EmployeeManagement.API.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> Departments();
        Department GetDepartment(int departmentId);
    }
}
