using MVCLabThrStd.Services;

namespace MVCLabThrStd.Models
{
    public class DepartmentMoc:IDepartment
    {
         List<DepartmentModel> departments = new List<DepartmentModel>()
        {
                new DepartmentModel{DeptId =1, DeptName ="PD"},
                new DepartmentModel{DeptId=2, DeptName="SA"},
                new DepartmentModel{DeptId =3, DeptName="AI"}
        };
        public List<DepartmentModel> getAllDepartments()
        {
            return departments;
        }
        public void AddDepartment(DepartmentModel dept)
        {
            departments.Add(dept);
        }
        public DepartmentModel getDepartment(int id)
        {
            return departments.FirstOrDefault(a => a.DeptId == id);
        }
        public void UpdateDepartment(DepartmentModel dept)
        {
            DepartmentModel oldDept = departments.FirstOrDefault(a => a.DeptId == dept.DeptId);
            oldDept.DeptName = dept.DeptName;

        }
        public void DeleteDepartment(int id)
        {
            DepartmentModel oldDept = departments.FirstOrDefault(a => a.DeptId == id);
            departments.Remove(oldDept);
        }
    }
}
