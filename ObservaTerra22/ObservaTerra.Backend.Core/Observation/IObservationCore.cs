using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    public interface IObservationCore
    {
        Observation GetObservation(int id);

        IEnumerable<Observation> FindObservations(string partialname);

        void AddObservation(Observation observation);
    }
}
