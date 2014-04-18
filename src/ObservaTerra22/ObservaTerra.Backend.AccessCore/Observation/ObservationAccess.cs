using ObservaTerra.Core;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    class ObservationAccess : IObservationAccess
    {
        public User User { get; private set; }

        public ObservationAccess(DomainModel.User user)
        {
            this.User = user;
        }

        public Observation GetObservation(int id)
        {
            IObservationCore core = CoreFactory.GetObservationCore();
            return core.GetObservation(id);
        }

        public IEnumerable<Observation> FindObservations(string partialname)
        {
            IObservationCore core = CoreFactory.GetObservationCore();
            return core.FindObservations(partialname);
        }
    }
}
