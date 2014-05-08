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
    public class AreaController : ApiControllerLogin
    {

        public Area Get(string token, int id)
        {
            User user = GetUserByToken(token);
            IAreaQuery query = DataQueryFactory.GetAreaQuery(user);
            return query.GetArea(id);
        }

        public IEnumerable<Area> Get(string token, string partialname)
        {
            User user = GetUserByToken(token);
            IAreaQuery query = DataQueryFactory.GetAreaQuery(user);
            return query.FindAreas(partialname);
        }

        public void Add(string token, Area area)
        {
            User user = GetUserByToken(token);
            IAreaCommand command = DataCommandFactory.GetAreaCommand(user);
            command.AddArea(area);
        }
    }
}
