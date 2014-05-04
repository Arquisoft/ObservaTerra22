using ObservaTerra.DomainModel;
using ObservaTerra.Web.Models;
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
            else if (result is GraphComponent)
                return View("DetailsGraph", result);
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

        public ViewResult CreateGraph()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGraph(GraphModel component)
        {
            if (ModelState.IsValid)
            {
                new ObservaTerra.Backend.WebService.Controllers.ComponentController().Add(User.Token, GetGraphComponent(component));
                return RedirectToAction("Index");
            }

            return View(component);
        }

        private GraphComponent GetGraphComponent(GraphModel graphmodel)
        {
            IList<Pair> pairs = new List<Pair>();
            string[] keys = graphmodel.Keys.Split(',');
            string[] values = graphmodel.Values.Split(',');

            for(int i = 0; i < keys.Length; i++)
            {
                pairs.Add(new Pair() { Key = keys[i], Value = values[i] });
            }
            return new GraphComponent() { Name = graphmodel.Name, Values = pairs };
        }
    }
}
