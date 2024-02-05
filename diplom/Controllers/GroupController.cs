using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace diplom.Controllers
{
    public class GroupController : Controller
    {
        // GET: GroupController
        public ActionResult AllGroups()
        {
            return View();
        }

        // GET: GroupController/Details/5
        public ActionResult IdGroup(int id)
        {
            return View();
        }

       
    }
}
