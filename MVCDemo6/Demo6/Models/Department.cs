using System.ComponentModel.DataAnnotations;

namespace Demo6.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        [Required]
        public string DeptName { get; set; }
       
    }
}
