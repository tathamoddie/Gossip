using System.Web.Mvc;

namespace Web.Controllers
{
    public class EventController : Controller
    {
        public ActionResult Join(string key)
        {
            if (key.Length > 0)
            {
                key = key.Substring(0, 1).ToUpperInvariant() + key.Substring(1);
            }
            ViewBag.EventKey = key;

            return View();
        }

        public ActionResult Host(string key)
        {
            return View();
        }
    }
}
