using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Departments
{
    public class DeleteModel : PageModel
    {
        IEntity<Department> db;
        public DeleteModel(IEntity<Department> _db)
        {
            db = _db;
        }
        [BindProperty]
        public Department department { get; set; }
        public void OnGet(int id)
        {
            department = db.GetById(id);
        }
        public IActionResult  OnPost() {
        
            if (department != null)
            {
                db.DeleteById(department.DeptId);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
