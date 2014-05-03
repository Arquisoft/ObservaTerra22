using ObservaTerra.DomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ObservationsController : Controller
    {
        public ViewResult Index(string partialname = "")
        {
            User user = Util.GetUser(User);
            var result = new ObservaTerra.Backend.WebService.Controllers.ObservationController().Get(null, "");

            return View(result);
        }


        #region · Create ·
        public ActionResult Create()
        {
            ViewData["indicators"] = GetIndicatorsSelectListItem();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Observation observation)
        {
            if (ModelState.IsValid)
            {
                User user = Util.GetUser(User);
                new ObservaTerra.Backend.WebService.Controllers.ObservationController().Post(null, observation);
                return RedirectToAction("Index");
            }

            return View(observation);
        }

        private IEnumerable<SelectListItem> GetIndicatorsSelectListItem()
        {
            var indicators = new ObservaTerra.Backend.WebService.Controllers.IndicatorController().Get(null, "");
            return indicators.Aggregate<Indicator, IList<SelectListItem>>(new List<SelectListItem>(), (lista, indicator) =>
                {
                    lista.Add(GetSelectListItem(indicator));
                    return lista;
                });
        }

        private SelectListItem GetSelectListItem(Indicator indicator)
        {
            return new SelectListItem() { Text = indicator.Name, Value = indicator.Id.ToString() };
        }
        #endregion
    }
}
