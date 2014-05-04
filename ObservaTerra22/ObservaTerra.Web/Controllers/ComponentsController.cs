using ObservaTerra.DomainModel;
using ObservaTerra.Web.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ComponentsController : BaseController
    {
        public ViewResult Index()
        {
            var result = new ObservaTerra.Backend.WebService.Controllers.ComponentController().Get(User.Token, "");
            return View(result);
        }

        public ViewResult Details(int id)
        {
            var result = new ObservaTerra.Backend.WebService.Controllers.ComponentController().Get(User.Token, id);

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
                new ObservaTerra.Backend.WebService.Controllers.ComponentController().Add(User.Token, component);
                return RedirectToAction("Index");
            }

            return View(component);
        }
    }
}
