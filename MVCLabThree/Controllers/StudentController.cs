using Microsoft.AspNetCore.Mvc;
using MVCLabThree.Models;

namespace MVCLabThree.Controllers
{
    public class StudentController : Controller
    {
        StudentMoc db = new StudentMoc();
        public IActionResult Index()
        {
            return View(db.getAllStudent());
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(StudentModel dept)
        {
            db.AddStudent(dept);
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();
            StudentModel dept = db.getStudent(id.Value);
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
            StudentModel dept = db.getStudent(id.Value);
            if (dept is null)
                return NotFound();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(StudentModel dept)
        {
            db.UpdateStudent(dept);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            StudentModel dept = db.getStudent(id);
            return View(dept);
        }
        [HttpPost, ActionName("delete")]
        public IActionResult DeleteConfirmed(int deptid)
        {
            db.DeleteStudent(deptid);
            return RedirectToAction("index");
        }
       
    }
}
