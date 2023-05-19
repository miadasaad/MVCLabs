using Demo6.Models;

namespace Demo6.Services
{
    public class StudentMoc:IEntity<Student>
    {
         List<Student> students= new List<Student>() { 
            new Student(){Id=1,Name="aly",Age=15},
            new Student(){Id=2,Name="sara",Age=20},
            new Student(){Id=3,Name="ahmed",Age=13},
            new Student(){Id=4,Name="ahlam",Age=14},
         };

        public Student Add(Student student)
        {
            students.Add(student);
            return student;
            //throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            Student s=GetById(id);
            students.Remove(s);
           // throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return students;
            //throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(a=>a.Id==id);
            //throw new NotImplementedException();
        }

        public Student Update(Student student)
        {
            Student s=GetById(student.Id);
            s.Name=student.Name;
            s.Age=student.Age;
            return s;
            //throw new NotImplementedException();
        }
    }
}
