using ObservaTerra.Backend.DataCommand;
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
   
    public class IndicatorController : ApiControllerLogin
    {
        public Indicator Get(string token, int id)
        {
            User user = GetUserByToken(token);
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(user);
            return query.GetIndicator(id);
        }

        public IEnumerable<Indicator> Get(string token, string partialname)
        {
            User user = GetUserByToken(token);
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(user);
            return query.FindIndicators(partialname);
        }

        public void Add(string token, Indicator indicator)
        {
            User user = GetUserByToken(token);
            IIndicatorCommand command = DataCommandFactory.GetIndicatorCommand(user);
            command.AddIndicator(indicator);
        }
    }
}
