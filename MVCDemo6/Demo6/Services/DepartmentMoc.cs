using Demo6.Models;
using System.ComponentModel;

namespace Demo6.Services
{
    public class DepartmentMoc : IEntity<Department>
    {
        List<Department> departments = new List<Department>() {
            new Department(){DeptId=1,DeptName="open source"},
            new Department(){DeptId=2,DeptName="PD"},
            new Department(){DeptId=3,DeptName="Ai"}
         };
        public Department Add(Department dept)
        {
            departments.Add(dept);
            return dept;
        }

        public void DeleteById(int id)
        {
            Department dept = GetById(id);
            departments.Remove(dept);
        }

        public List<Department> GetAll()
        {
            return departments;
        }

        public Department GetById(int id)
        {
            Department dept = departments.FirstOrDefault(a => a.DeptId == id);
            return dept;
        }

        public Department Update(Department department)
        {
            Department dept = departments.FirstOrDefault(a => a.DeptId == department.DeptId );
            dept.DeptName = department.DeptName;
            return dept;
        }
    }
}
