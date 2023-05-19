using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace Demo6.Pages.Departments
{
	public class EditModel : PageModel
	{
		IEntity<Department> db;
		public EditModel(IEntity<Department> _db)
		{
			db = _db;
		}
		[BindProperty]
		public Department department { get; set; }
		public void OnGet(int id)
		{
			department = db.GetById(id);
		}
		public IActionResult OnPost() {
			if (ModelState.IsValid) {
				db.Update(department);
				return RedirectToPage("Index");
			}
			return Page();
		}

	
    }
}
