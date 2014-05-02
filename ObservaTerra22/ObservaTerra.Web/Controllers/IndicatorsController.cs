using ObservaTerra.Backend.DataQuery;
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
        public Indicator Get(string token, int id)
        {
            User user = Util.GetUser(User);
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(user);
            return query.GetIndicator(id);
        }

        public IEnumerable<Indicator> Get(string token, string partialname)
        {
            User user = Util.GetUser(User);
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(user);
            return query.FindIndicators(partialname);
        }
    }
}
