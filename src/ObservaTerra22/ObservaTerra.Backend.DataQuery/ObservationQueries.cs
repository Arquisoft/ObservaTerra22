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
        public Observation GetObservation(int id)
        {
            IObservationAccess access = AccessCoreFactory.GetObservationAccess();
            return access.GetObservation(id);
        }

    }
}
