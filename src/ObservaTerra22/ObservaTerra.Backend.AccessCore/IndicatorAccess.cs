using ObservaTerra.Core;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    class IndicatorAccess : IIndicatorAccess
    {
        public User User { get; private set; }

        public IndicatorAccess(DomainModel.User user)
        {
            this.User = user;
        }

        public Indicator GetIndicator(int id)
        {
            IIndicatorCore core = CoreFactory.GetIndicatorCore();
            return core.GetIndicator(id);
        }

        public IEnumerable<Indicator> FindIndicators(string partialname)
        {
            IIndicatorCore core = CoreFactory.GetIndicatorCore();
            return core.FindIndicators(partialname);
        }
    }
}
