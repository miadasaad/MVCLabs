using Microsoft.AspNetCore.Mvc;
using MVCLabThrStd.Models;
using MVCLabThrStd.Services;

namespace MVCLabThrStd.Controllers
{
    public class DepartmentController : Controller
    {
       // DepartmentDb db = new DepartmentDb();
        // DepartmentMoc db = new DepartmentMoc();
        //ITI db = new ITI();
        IDepartment db;
        public DepartmentController(IDepartment _db)
        {
            db = _db;
        }
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
        public IActionResult create(DepartmentModel dept)
        {
            db.AddDepartment(dept);
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();
            DepartmentModel dept = db.getDepartment(id.Value);
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
            DepartmentModel dept = db.getDepartment(id.Value);
            if (dept is null)
                return NotFound();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentModel dept)
        {
            db.UpdateDepartment(dept);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            DepartmentModel dept = db.getDepartment(id.Value);
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
