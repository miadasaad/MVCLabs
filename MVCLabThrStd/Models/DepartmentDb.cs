using MVCLabThrStd.Services;

namespace MVCLabThrStd.Models
{
    public class DepartmentDb:IDepartment 
    {
        //List<DepartmentModel> departments = new List<DepartmentModel>()
        //{
        //        new DepartmentModel{DeptId =1, DeptName ="PD"},
        //        new DepartmentModel{DeptId=2, DeptName="SA"},
        //        new DepartmentModel{DeptId =3, DeptName="AI"}
        //};
        // ITI db = new ITI();
        ITI db;
        public DepartmentDb(ITI _db)
        {
            db = _db;
        }
        public List<DepartmentModel> getAllDepartments()
        {
            return db.Departments.ToList();
        }
        public void AddDepartment(DepartmentModel dept)
        {
            db.Departments.Add(dept);
            db.SaveChanges();
        }
        public DepartmentModel getDepartment(int id)
        {
            return db.Departments.FirstOrDefault(a => a.DeptId == id);
        }
        public void UpdateDepartment(DepartmentModel dept)
        {
            DepartmentModel oldDept = db.Departments.FirstOrDefault(a => a.DeptId == dept.DeptId);
            oldDept.DeptName = dept.DeptName;
            db.SaveChanges();

        }
        public void DeleteDepartment(int id)
        {
            DepartmentModel oldDept = db.Departments.FirstOrDefault(a => a.DeptId == id);
            db.Departments.Remove(oldDept);
        }
    }
}
