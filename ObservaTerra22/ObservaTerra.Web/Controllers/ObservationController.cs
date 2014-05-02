using ObservaTerra.Backend.DataQuery;
using ObservaTerra.Backend.HumanData;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ObservaTerra.Backend.WebService.Controllers
{
    public class ObservationController : Controller
    {
        public Observation Get(string token, int id)
        {
            User user = GetUserByToken(token);
            IObservationQuery query = DataQueryFactory.GetObservationQueries(user);
            return query.GetObservation(id);
        }

        public IEnumerable<Observation> Get(string token, string partialname)
        {
            User user = GetUserByToken(token);
            IObservationQuery query = DataQueryFactory.GetObservationQueries(user);
            return query.FindObservations(partialname);
        }

        public void Post(string token, Observation observation)
        {
            User user = GetUserByToken(token);
            IObservationHumanData humandata = HumanDataFactory.GetObservationHumanData(user);
            humandata.AddObservation(observation);
        }
    }
}
