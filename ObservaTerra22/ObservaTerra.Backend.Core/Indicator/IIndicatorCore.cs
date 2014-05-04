using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    public interface IIndicatorCore
    {
        Indicator GetIndicator(int id);

        IEnumerable<Indicator> FindIndicators(string partialname);

        void Add(Indicator indicator);
    }
}
