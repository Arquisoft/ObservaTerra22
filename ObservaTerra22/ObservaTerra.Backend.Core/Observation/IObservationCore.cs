using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Core
{
    public interface IObservationCore
    {
        Observation GetObservation(int id);

        IEnumerable<Observation> FindObservations(string partialname);

        void AddObservation(Observation observation);
    }
}
