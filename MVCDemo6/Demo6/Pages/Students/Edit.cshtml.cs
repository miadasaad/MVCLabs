using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Students
{
    public class EditModel : PageModel
    {
        private IEntity<Student> db;

        public EditModel(IEntity<Student> _db)
        {
            db = _db;
        }
        [BindProperty]
        public Student   Student { get; set; }
        public void OnGet(int id)
        {
            Student = db.GetById(id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Update(Student);
                return RedirectToPage("Index");
            }
            else
                return Page();

        }
    }
}
