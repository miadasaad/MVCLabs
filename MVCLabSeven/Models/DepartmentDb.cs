using MVCLabSeven.Services;

namespace MVCLabSeven.Models
{
    public class DepartmentDb:IDepartment
    {
        ITIContext db = new ITIContext();
        //public DepartmentDb(ITIContext _db)
        //{
        //    db = _db;
        //}
        public List<Department> getAllDepartments()
        {
            return db.Departments.ToList();
        }
        public void AddDepartment(Department dept)
        {
            db.Departments.Add(dept);
            db.SaveChanges();
        }
        public Department getDepartment(int id)
        {
            return db.Departments.FirstOrDefault(a => a.DeptId == id);
        }
        public void UpdateDepartment(Department dept)
        {
            Department oldDept = db.Departments.FirstOrDefault(a => a.DeptId == dept.DeptId);
            oldDept.DeptName = dept.DeptName;
            db.SaveChanges();

        }
        public void DeleteDepartment(int id)
        {
            Department oldDept = db.Departments.FirstOrDefault(a => a.DeptId == id);
            db.Departments.Remove(oldDept);
        }
    }
}
