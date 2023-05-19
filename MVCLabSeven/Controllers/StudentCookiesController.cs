using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCLabSeven.Controllers
{
    public class StudentCookiesController : Controller
    {
        public IActionResult Index()
        {
            int id = 5;
            string name = "mayada";
            //session
            //HttpContext.Session.SetInt32("id", id);
            //HttpContext.Session.SetString("name", name);
            //cookies
            Response.Cookies.Append("id", id.ToString(), new CookieOptions() { Expires = DateTime.Now.AddHours(5) });
            Response.Cookies.Append("name", name);
            return Content("Index Action");
        }
        public IActionResult Show()
        {
            //session
            //int idd = HttpContext.Session.GetInt32("id").Value;
            //string name = HttpContext.Session.GetString("name");
            //cookies
            int id = int.Parse(Request.Cookies["id"]);
            return Content("Show Action"+":::"+id+":::");
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
