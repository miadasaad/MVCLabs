using Microsoft.EntityFrameworkCore;

namespace MVCLabSeven.Models
{
    public class StudentDb
    {
        ITIContext db = new ITIContext();
        public List<Student> getAllStd()
        {
            return db.Students.Include(a => a.Department).ToList();
        }
        /// <summary>
        /// //////////////////
        /// </summary>
        /// <returns></returns>
        public List<Department> getAllDepts()
        {
            return db.Departments.ToList();
        }
        /// <summary>
        /// ////////////////
        /// </summary>
        /// <param name="std"></param>
        public void AddStudent(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
        }
        public Student getStudentById(int id)
        {
            Student std = db.Students.FirstOrDefault(st => st.Id == id);
            return std;
        }
        public void updateStudent(Student std)
        {
            Student ex = db.Students.FirstOrDefault(st => st.Id == std.Id);
            if (ex != null)
            {
                ex.Name = std.Name;
                ex.age = std.age;
            }
            db.SaveChanges();
        }
        public void deleteStudent(int id)
        {
            Student std = db.Students.FirstOrDefault(st => st.Id == id);
            db.Students.Remove(std);
            db.SaveChanges();
        }
        public Student isExist(string email)
        {
            return db.Students.FirstOrDefault(a => a.Email == email);
        }
    }
}
