using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    public interface IIndicatorPersistenceManagement
    {
        Indicator GetIndicator(int id);

        IEnumerable<Indicator> FindIndicators(string partialname);

        void Add(Indicator indicator);
    }
}
