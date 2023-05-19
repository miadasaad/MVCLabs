using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IEntity<Student> db;

        public DetailsModel(IEntity<Student> _db)
        {
            db = _db;
        }
        public Student student { get; set; }   
        public IActionResult OnGet(int? id)
        {
            if (id is null)
                return BadRequest();
            var s=db.GetById(id.Value);
            if(s==null) return NotFound();
            student= s;
            return Page();
        }
    }
}
