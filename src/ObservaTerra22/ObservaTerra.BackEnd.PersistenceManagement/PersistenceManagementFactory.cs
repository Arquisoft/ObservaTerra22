using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    public static class PersistenceManagementFactory
    {
        public static IObservationPersistenceManagement GetObservationPersistenceManagement()
        {
            return new ObservationPersistenceManagement();
        }
    }
}
