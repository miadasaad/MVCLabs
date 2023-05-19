using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabSeven.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        public string? DeptName { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
