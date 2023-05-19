using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Departments
{
    public class DetailsModel : PageModel
    {
		private readonly IEntity<Department> db;

		public DetailsModel(IEntity<Department> _db)
		{
			db = _db;
		}
		public Department dept { get; set; }
		public IActionResult OnGet(int? id)
        {
			if (id == null)
			{
				return BadRequest();
			}
			dept = db.GetById(id.Value);
			if (dept == null)
				return NotFound();
			return Page();
		}
    }
}
