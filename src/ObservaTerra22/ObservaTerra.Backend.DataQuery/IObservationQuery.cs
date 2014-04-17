using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    public interface IObservationQuery
    {
        User User { get; }

        Observation GetObservation(int id);

        IEnumerable<Observation> FindObservations(string partialname);
    }
}