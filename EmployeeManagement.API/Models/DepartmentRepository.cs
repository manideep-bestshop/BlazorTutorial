using EmployeeManagement.Models;

namespace EmployeeManagement.API.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;

        }
        public IEnumerable<Department> Departments()
        {
            return _appDbContext.Departments;
        }

        public Department GetDepartment(int departmentId)
        {
            return _appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }
    }
}
