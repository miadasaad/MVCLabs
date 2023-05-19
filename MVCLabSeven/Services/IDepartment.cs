using MVCLabSeven.Models;

namespace MVCLabSeven.Services
{
    public interface IDepartment
    {
        public interface IDepartment
        {
            public List<Department> getAllDepartments();
            public void AddDepartment(Department dept);
            public Department getDepartment(int id);
            public void UpdateDepartment(Department dept);
            public void DeleteDepartment(int id);
        }
    }
}
