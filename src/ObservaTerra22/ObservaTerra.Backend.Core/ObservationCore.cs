using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Core
{
    class ObservationCore : IObservationCore
    {
        public Observation GetObservation(int id)
        {
            IObservationPersistenceManagement persistence = PersistenceManagementFactory.GetObservationPersistenceManagement();
            return persistence.GetObservation(id);
        }


        public IEnumerable<Observation> FindObservations(string partialname)
        {
            IObservationPersistenceManagement persistence = PersistenceManagementFactory.GetObservationPersistenceManagement();
            return persistence.FindObservations(partialname);
        }
    }
}
