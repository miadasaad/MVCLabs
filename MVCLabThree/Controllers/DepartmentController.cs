using Microsoft.AspNetCore.Mvc;
using MVCLabThree.Models;

namespace MVCLabThree.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentMoc db = new DepartmentMoc();
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
        public IActionResult Delete(int id)
        {
            DepartmentModel dept = db.getDepartment(id);
            return View(dept);
        }
        [HttpPost, ActionName("delete")]
        public IActionResult DeleteConfirmed(int deptid)
        {
            db.DeleteDepartment(deptid);
            return RedirectToAction("index");
        }
    }
}


//DepartmentMoc db = new DepartmentMoc();
//public IActionResult Index(int hamada)
//{

//    //ViewData["depts"] = model;         
//    //ViewData.Model = model;
//    //return new ViewResult() { ViewName= "Index" ,ViewData=ViewData};
//    return View(db.GetAllDepartments());
//}
//[HttpGet]
//public IActionResult Create()
//{
//    return View();
//}


////form , posted data
////routing system
////query string
//[HttpPost]
//public IActionResult Create(Department dept)//id ,name , capacity//model binder
//{
//    //dept.DeptId ,dept.deptname , dept.capacity
//    //DeptId ,, deptname ,capacity

//    // Department dept=new Department() { DeptId=id,DeptName=name,Capacity=capacity};
//    db.AddDepartment(dept);
//    return RedirectToAction("index");
//    // return View("index", db.GetAllDepartments());
//    //int id=0;
//    //string name;
//    //int capacity;
//    //name = Request.Query["name"];
//    //capacity = int.Parse(Request.Query["capacity"]);
//    //id = int.Parse((Request.RouteValues["id"].ToString()));
//}
//public IActionResult Details(int? id)
//{

//    if (id is null)
//        return BadRequest();
//    Department dept = db.GetDepartmentById(id.Value);
//    if (dept is null)
//        return NotFound();
//    return View(dept);

//}
//[HttpGet]
//public IActionResult Edit(int? id)
//{
//    if (id is null)
//        return BadRequest();
//    Department dept = db.GetDepartmentById(id.Value);
//    if (dept is null)
//        return NotFound();
//    return View(dept);
//}
//[HttpPost]
//public IActionResult Edit(Department dept)
//{
//    db.Updtae(dept);
//    return RedirectToAction("index");
//}
//public IActionResult Delete(int id)
//{
//    Department dept = db.GetDepartmentById(id);
//    return View(dept);
//}
//[HttpPost, ActionName("delete")]
//public IActionResult DeleteConfirmed(int deptid)
//{
//    db.Delete(deptid);
//    return RedirectToAction("index");
//}