using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabThrStd.Models
{
    public class DepartmentModel
    {
        

        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        public string? DeptName { get; set; }

        public virtual ICollection<StudentModel> Students { get; set; } = new HashSet <StudentModel>();
    }
}
