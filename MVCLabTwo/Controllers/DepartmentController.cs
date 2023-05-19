using Microsoft.AspNetCore.Mvc;
using MVCLabTwo.Models;

namespace MVCLabTwo.Controllers
{
    public class DepartmentController : Controller
    {
        public ViewResult Index()
        {
            List<DepartmentModelView> departments = new List<DepartmentModelView>
            {
                new DepartmentModelView {DeptId=1, DeptName ="PD track"},
                 new DepartmentModelView {DeptId=2, DeptName ="SA track"},
                 new DepartmentModelView {DeptId=3, DeptName ="Mobile track"}
            };

            ViewData["Depts"] = departments;
            ViewBag.depts = departments;
            return View();
        }
    }
}
