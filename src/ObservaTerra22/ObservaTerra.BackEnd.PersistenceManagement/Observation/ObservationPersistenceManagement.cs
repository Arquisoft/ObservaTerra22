using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    class ObservationPersistenceManagement : IObservationPersistenceManagement
    {
        public Observation GetObservation(int id)
        {
            Observation result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.Observations.Single(o => o.Id == id);
            }

            return result;
        }


        public IEnumerable<Observation> FindObservations(string partialname)
        {
            IEnumerable<Observation> result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.Observations.Where(o => o.Indicator.Name.Contains(partialname));
            }

            return result;
        }


        public void AddObservation(Observation observation)
        {
            using (var container = new DomainModelContainer())
            {
                container.Observations.Add(observation);
                container.SaveChanges();
            }
        }
    }
}
