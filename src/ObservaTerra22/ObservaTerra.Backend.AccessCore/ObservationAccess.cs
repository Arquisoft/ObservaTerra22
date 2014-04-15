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
        public Observation GetObservation(int id)
        {
            IObservationCore core = CoreFactory.GetObservationCore();
            return core.GetObservation(id);
        }
    }
}
