using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    public interface IIndicatorAccess
    {
        User User { get; }

        Indicator GetIndicator(int id);

        IEnumerable<Indicator> FindIndicators(string partialname);

        void Add(Indicator indicator);
    }
}
