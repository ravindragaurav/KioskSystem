using Database;
using System.Linq;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class KioskController : Controller
    {
        public ActionResult Kiosk()
        {
            var context = new KisokDatabase();
            var items = context.Item.Select(x=>x.Name);
            var array = items.ToArray();
            ViewBag.data = array;
            return View();
        }
    }
}