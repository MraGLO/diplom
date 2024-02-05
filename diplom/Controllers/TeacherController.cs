using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace diplom.Controllers
{
    public class TeacherController : Controller
    {
        // GET: TeacherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeacherController/IdTeacher/5
        public ActionResult IdTeacher(int id)
        {
            return View();
        }

        
    }
}
