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

        public IComponent Get(int id)
        {
            IComponentQuery query = DataQueryFactory.GetComponentQuery(DefaultUser);
            return query.GetComponent(id);
        }

        public IEnumerable<IComponent> Get(string partialname)
        {
            IComponentQuery query = DataQueryFactory.GetComponentQuery(DefaultUser);
            return query.FindComponents(partialname);
        }
    }
}
