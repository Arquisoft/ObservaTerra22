using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Core
{
    class IndicatorCore : IIndicatorCore
    {
        public Indicator GetIndicator(int id)
        {
            IIndicatorPersistenceManagement persistence = PersistenceManagementFactory.GetIndicatorPersistenceManagement();
            return persistence.GetIndicator(id);
        }

        public IEnumerable<Indicator> FindIndicators(string partialname)
        {
            IIndicatorPersistenceManagement persistence = PersistenceManagementFactory.GetIndicatorPersistenceManagement();
            return persistence.FindIndicators(partialname);
        }
    }
}
