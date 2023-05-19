using Microsoft.AspNetCore.Mvc;
using MVCLabSeven.Models;
using MVCLabSeven.Services;

namespace MVCLabSeven.Controllers
{
    public class DepartmentController : Controller
    {
        //IDepartment db;
        //public DepartmentController(IDepartment _db)
        //{
        //    db = _db;
        //}
         DepartmentDb db = new DepartmentDb();
        public IActionResult Index()
        {
            
            return View(db.getAllDepartments());
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Department dept)
        {
            db.AddDepartment(dept);
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();
            Department dept = db.getDepartment(id.Value);
            if (dept == null)
                return NotFound();
            else
                return View(dept);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null)
                return BadRequest();
            Department dept = db.getDepartment(id.Value);
            if (dept is null)
                return NotFound();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(Department dept)
        {
            db.UpdateDepartment(dept);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            Department dept = db.getDepartment(id.Value);
            return View(dept);
        }
        [HttpPost]
        public IActionResult Delete(int deptid)
        {
            db.DeleteDepartment(deptid);
            return RedirectToAction("index");
        }
    }
}
