using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Departments
{
    public class IndexModel : PageModel
    {
		IEntity<Department> db;
        public IndexModel(IEntity<Department> _db)
        {
            db = _db;
        }
        public List<Department> departments { get; set; }
		public void OnGet()
        {
            departments = db.GetAll();
        }
    }
}
