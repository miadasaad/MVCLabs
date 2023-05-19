using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IEntity<Student> db;

        public CreateModel(IEntity<Student> _db)
        {
            db = _db;
        }
        [BindProperty]
        public Student Student { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                db.Add(Student);
                return RedirectToPage("Index");
            }
            else
                return Page();
        
        }
    }
}
