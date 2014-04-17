using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    class ObservationQuery : IObservationQuery
    {
        public User User { get; private set; }

        public ObservationQuery(User user)
        {
            this.User = user;
        }

        public Observation GetObservation(int id)
        {
            IObservationAccess access = AccessCoreFactory.GetObservationAccess(User);
            return access.GetObservation(id);
        }

        public IEnumerable<Observation> FindObservations(string partialname)
        {
            IObservationAccess access = AccessCoreFactory.GetObservationAccess(User);
            return access.FindObservations(partialname);
        }
    }
}
