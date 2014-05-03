using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
   
    public class IndicatorsController : Controller
    {
        /*public Indicator Get(int id)
        {
            User user = Util.GetUser(User);
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(user);
            return query.GetIndicator(id);
        }*/

        public ViewResult Index(string partialname = "")
        {
            User user = Util.GetUser(User);
            //This is a test, source should be cleaner.
            return View(new ObservaTerra.Backend.WebService.Controllers.IndicatorController().Get(null, ""));
        }
    }
}
