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
        private User DefaultUser
        {
            get
            {
                return new User();
            }
        }

        public Observation Get(int id)
        {
            IObservationQuery query = DataQueryFactory.GetObservationQueries(DefaultUser);
            return query.GetObservation(id);
        }

        public IEnumerable<Observation> Get(string partialname)
        {
            IObservationQuery query = DataQueryFactory.GetObservationQueries(DefaultUser);
            return query.FindObservations(partialname);
        }
    }
}
