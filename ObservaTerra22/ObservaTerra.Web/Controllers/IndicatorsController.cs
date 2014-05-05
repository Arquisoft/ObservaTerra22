using ObservaTerra.Backend.WebService;
using ObservaTerra.DomainModel;
using ObservaTerra.Web.Models;
using ObservaTerra.Web.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{

    public class IndicatorsController : BaseController
    {
        [Authorize]
        public ActionResult Create()
        {
            return View(new IndicatorModel() { Observations = GetObservationsSelectListItem(), Areas = GetAreasSelectListItem()});
        }

        [HttpPost]
        public ActionResult Create(IndicatorModel indicator)
        {
            if (ModelState.IsValid)
            {
                Factory.GetIndicatorController().Add(User.Token, GetIndicator(indicator));
                return RedirectToAction("Index");
            }

            return View(indicator);
        }

        private Indicator GetIndicator(IndicatorModel indicator)
        {
            var result = new Indicator() { Name = indicator.Name };
            var observations = Factory.GetObservationController().Get(User.Token, "");

            foreach (var item in observations.Where(c => indicator.SelectedObservations.Any(sl => sl == c.Id.ToString())))
            {
                result.Observations.Add(item);
            }

            var areas = Factory.GetAreaController().Get(User.Token, "");
            result.Area = areas.Single(a => a.Id.ToString() == indicator.SelectedArea);

            result.ITime = new TimeInstant() { Value = indicator.Instant.Ticks };

            

            return result;
        }


        public ViewResult Index(string partialname = "")
        {
            var result = Factory.GetIndicatorController().Get(User.Token, "");
            return View(result);
        }

        public ViewResult Details(int id)
        {
            var result = Factory.GetIndicatorController().Get(User.Token, id);
            return View(result);
        }

        private IList<SelectListItem> GetObservationsSelectListItem()
        {
            var observations = Factory.GetObservationController().Get(User.Token, "");
            return observations.Aggregate<Observation, IList<SelectListItem>>(new List<SelectListItem>(), (lista, observation) =>
            {
                lista.Add(GetSelectListItem(observation));
                return lista;
            });
        }

        private SelectListItem GetSelectListItem(Observation observation)
        {
            return new SelectListItem() { Text = observation.Name, Value = observation.Id.ToString() };
        }

        private IList<SelectListItem> GetAreasSelectListItem()
        {
            var areas = Factory.GetAreaController().Get(User.Token, "");
            return areas.Aggregate<Area, IList<SelectListItem>>(new List<SelectListItem>(), (lista, area) =>
            {
                lista.Add(GetSelectListItem(area));
                return lista;
            });
        }

        private SelectListItem GetSelectListItem(Area area)
        {
            return new SelectListItem() { Text = area.Name, Value = area.Id.ToString() };
        }
    }
}
