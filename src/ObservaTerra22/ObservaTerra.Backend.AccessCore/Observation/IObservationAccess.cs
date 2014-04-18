using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    public interface IObservationAccess
    {
        User User { get; }

        Observation GetObservation(int id);

        IEnumerable<Observation> FindObservations(string partialname);
    }
}
