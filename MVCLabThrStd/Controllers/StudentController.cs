using Microsoft.AspNetCore.Mvc;
using MVCLabThrStd.Models;

namespace MVCLabThrStd.Controllers
{
    public class StudentController : Controller
    {
        StudentMoc stds = new StudentMoc();
        public IActionResult Index()
        {
            return View(stds.getAllStd());
        }
        // i used it when writing the parameters in url
        [HttpPost]
        public IActionResult Create(StudentModel std)
        {
            if (ModelState.IsValid)
            {
                stds.AddStudent(std);
                return RedirectToAction("Index");
            }
            return View(std);

        }
        //i will write in the path this create first to show the form,then when
        //click submit button it will go to the above create to show us the view
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //details
        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();
            StudentModel std = stds.getStudentById(id.Value);
            if (std is null)
                return NotFound();
            return View(std);
        }

        // edit 
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null)
                return BadRequest();
            StudentModel std = stds.getStudentById(id.Value);
            if (std is null)
                return NotFound();
            return View(std);
        }
        [HttpPost]
        public IActionResult Edit(StudentModel std)
        {
            stds.updateStudent(std);
            return RedirectToAction("index");
        }
        //delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null)
                return BadRequest();
            StudentModel std = stds.getStudentById(id.Value);
            if (std is null)
                return NotFound();
            return View(std);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            stds.deleteStudent(id);
            return RedirectToAction("index");
        }
        public IActionResult checkEmail(string Email)
        {
            if (stds.isExist(Email) != null)
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
    }
}
