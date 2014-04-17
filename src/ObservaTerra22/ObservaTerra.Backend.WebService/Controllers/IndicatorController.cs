using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ObservaTerra.Backend.WebService.Controllers
{
    public class IndicatorController : ApiController
    {
        private User DefaultUser
        {
            get
            {
                return new User();
            }
        }

        public Indicator Get(int id)
        {
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(DefaultUser);
            return query.GetIndicator(id);
        }

        public IEnumerable<Indicator> Get(string partialname)
        {
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(DefaultUser);
            return query.FindIndicators(partialname);
        }
    }
}
