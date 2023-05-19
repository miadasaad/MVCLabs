using Demo6.Models;
using Demo6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo6.Pages.Students
{
    public class IndexModel : PageModel
    {
        IEntity<Student> db;
        public IndexModel(IEntity<Student> _db)
        {
            db = _db;
        }
        public List<Student>    Students { get; set; }
        public void OnGet()
        {
            Students = db.GetAll();
        }
    }
}
