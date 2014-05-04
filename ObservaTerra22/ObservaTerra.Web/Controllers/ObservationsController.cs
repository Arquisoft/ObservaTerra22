using ObservaTerra.DomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ObservationsController : BaseController
    {
        public ViewResult Index(string partialname = "")
        {
            var result = new ObservaTerra.Backend.WebService.Controllers.ObservationController().Get(User.Token, "");

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
                new ObservaTerra.Backend.WebService.Controllers.ObservationController().Post(User.Token, observation);
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
