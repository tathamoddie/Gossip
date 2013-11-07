using System.Web.Mvc;

namespace Web.Controllers
{
    public class EventController : Controller
    {
        public ActionResult Join(string key)
        {
            return View();
        }

        public ActionResult Host(string key)
        {
            return View();
        }
    }
}
