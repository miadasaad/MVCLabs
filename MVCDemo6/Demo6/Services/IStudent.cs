using Demo6.Models;

namespace Demo6.Services
{
    public interface IEntity<t>
    {
        public List<t> GetAll();
        public t GetById(int id);
        public t Add(t student);
        public t Update(t student);
        public void DeleteById(int id);
    }
    public interface IStudent
    {
        public List<Student> GetAll();
        public Student GetById(int id);
        public Student Add(Student student);
        public Student Update(Student student);
        public void DeleteById(int id);
    }
}
