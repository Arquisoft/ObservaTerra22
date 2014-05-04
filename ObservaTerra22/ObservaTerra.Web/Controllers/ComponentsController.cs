using ObservaTerra.DomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ComponentsController : Controller
    {
        public ViewResult Index()
        {
            User user = Util.GetUser(User);
            var result = new ObservaTerra.Backend.WebService.Controllers.ComponentController().Get(null, "");
            return View(result);
        }

        public ViewResult Details(int id)
        {
            User user = Util.GetUser(User);
            var result = new ObservaTerra.Backend.WebService.Controllers.ComponentController().Get(null, id);
            if (result is TextComponent)
                return View("DetailsText", result);
            return View();
        }

        public ViewResult CreateText()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateText(TextComponent component)
        {
            if (ModelState.IsValid)
            {
                User user = Util.GetUser(User);
                new ObservaTerra.Backend.WebService.Controllers.ComponentController().Add(null, component);
                return RedirectToAction("Index");
            }

            return View(component);
        }
    }
}
