namespace MVCLabThree.Models
{
    public class StudentMoc
    {
        static List<StudentModel> students = new List<StudentModel>()
        {
                new StudentModel{Id=1, Name="Mayada" , age=25},
                new StudentModel{Id=2, Name="Saad" , age=55},
                new StudentModel{Id=3, Name="Ahmed" , age=23}
        };

        public List<StudentModel> getAllStudent()
        {
            return students;
        }
        public void AddStudent(StudentModel dept)
        {
            students.Add(dept);
        }
        public StudentModel getStudent(int id)
        {
            return students.FirstOrDefault(a => a.Id == id);
        }
        public void UpdateStudent(StudentModel dept)
        {
            StudentModel oldDept = students.FirstOrDefault(a => a.Id == dept.Id);
            oldDept.Name = dept.Name;

        }
        public void DeleteStudent(int id)
        {
            StudentModel oldDept = students.FirstOrDefault(a => a.Id == id);
            students.Remove(oldDept);
        }
    }
}
