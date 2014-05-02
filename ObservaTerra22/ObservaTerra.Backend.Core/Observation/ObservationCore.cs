using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

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

        public void AddObservation(Observation observation)
        {
            IObservationPersistenceManagement persistence = PersistenceManagementFactory.GetObservationPersistenceManagement();
            persistence.AddObservation(observation);
        }
    }
}
