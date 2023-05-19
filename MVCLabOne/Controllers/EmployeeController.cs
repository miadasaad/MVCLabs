using Microsoft.AspNetCore.Mvc;

namespace MVCLabOne.Controllers
{
    public class EmployeeController : Controller
    {

       // function return string
       public string displayName()
        {
            return "Hello Mayada";
        }

        // function return integer
        public int getNumber(int n)
        {
            return n+5;
        }

        //view
        public ViewResult Show()
        {
            return View();
        }
    }
}
