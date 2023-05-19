using Microsoft.AspNetCore.Mvc;
using MVCLabTwo.Models;

namespace MVCLabTwo.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult  Index()
        {
            List<StudentModelView> students = new List<StudentModelView>
            {
      new StudentModelView{Id=1 , Name="Mayada" , Age=55 },
      new StudentModelView{Id=2 , Name="Saad" , Age=66 },
      new StudentModelView{Id=3 , Name="Mayada" , Age=55 }
            };

            return View(students);
        }
    }
}
