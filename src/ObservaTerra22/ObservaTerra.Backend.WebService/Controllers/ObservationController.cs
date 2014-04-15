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
    public class ObservationController : ApiController
    {
        public Observation Get(int id)
        {
            IObservationQuery query = DataQueryFactory.GetObservationQueries();
            return query.GetObservation(id);
        }
    }
}
