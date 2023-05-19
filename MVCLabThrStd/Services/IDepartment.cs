using MVCLabThrStd.Models;

namespace MVCLabThrStd.Services
{
    public interface IDepartment
    {
        public List<DepartmentModel> getAllDepartments();
        public void AddDepartment(DepartmentModel dept);
        public DepartmentModel getDepartment(int id);
        public void UpdateDepartment(DepartmentModel dept);
        public void DeleteDepartment(int id);
    }
}
