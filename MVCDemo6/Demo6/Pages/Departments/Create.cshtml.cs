using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Departments
{
    public class CreateModel : PageModel
    {
        IEntity<Department> db;
        public CreateModel(IEntity<Department> _db)
		{
            db = _db;
		}
        [BindProperty]
        public Department department { get; set; }
		public void OnGet()
        {
        }
        public IActionResult OnPost()
		{
            if (ModelState.IsValid)
            {
                db.Add(department);
                return RedirectToPage("Index");
            }
            else
                return Page();
		}
	}
}
