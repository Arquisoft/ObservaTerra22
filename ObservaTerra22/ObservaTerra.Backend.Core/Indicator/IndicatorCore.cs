using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

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


        public void Add(Indicator indicator)
        {
            IIndicatorPersistenceManagement persistence = PersistenceManagementFactory.GetIndicatorPersistenceManagement();
            persistence.Add(indicator);
        }
    }
}
