using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    public interface IObservationPersistenceManagement
    {
        Observation GetObservation(int id);
    }
}
