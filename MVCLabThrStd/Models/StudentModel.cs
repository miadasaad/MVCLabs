using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabThrStd.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="*"),StringLength(10,MinimumLength =3) ]
        public string Name { get; set; }
        [Range(10,20)]
        public int age { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z0-9]+@[a-zA-Z]+.[a-zA-Z]{2,4}") ]
        [Remote("checkEmail","student")]
        public string Email { get; set; }
        [Required, StringLength(10, MinimumLength = 3)]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string CPassword { get; set; }
        [ForeignKey("DepartmentModel")]
        public int DeptNo { get; set; }
        public virtual DepartmentModel DepartmentModel { get; set; }
    }
}
