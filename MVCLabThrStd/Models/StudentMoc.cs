namespace MVCLabThrStd.Models
{
    public class StudentMoc
    {
        static List<StudentModel> students = new List<StudentModel>()
        {
            new StudentModel{Id= 1, Name="Mayada" , age =25,Email ="mayada@gmail.com"},
            new StudentModel{Id= 2, Name="Saad" , age =55,Email ="saad@gmail.com"},
            new StudentModel{Id= 3, Name="Ahmed" , age =23,Email ="ahmed@gmail.com"}
        };

        public List<StudentModel> getAllStd()
        {
            return students;
        }
        public void AddStudent(StudentModel std)
        {
            students.Add(std);
        }
        public StudentModel getStudentById(int id)
        {
            StudentModel std = students.FirstOrDefault(st => st.Id == id);
            return std;
        }
        public void updateStudent(StudentModel std)
        {
            StudentModel ex = students.FirstOrDefault(st => st.Id == std.Id);
            if (ex != null)
            {
                ex.Name = std.Name;
                ex.age = std.age;
            }
        }
        public void deleteStudent(int id)
        {
            StudentModel std = students.FirstOrDefault(st => st.Id == id);
            students.Remove(std);
        }
        public StudentModel isExist(string email)
        {
            return students.FirstOrDefault(a => a.Email == email);
        }
    }
}
