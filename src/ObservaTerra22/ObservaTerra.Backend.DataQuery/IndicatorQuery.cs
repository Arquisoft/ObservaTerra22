using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    class IndicatorQuery : IIndicatorQuery
    {
        public User User { get; private set; }

        public IndicatorQuery(User user)
        {
            this.User = user;
        }

        public Indicator GetIndicator(int id)
        {
            IIndicatorAccess access = AccessCoreFactory.GetIndicatorAccess(User);
            return access.GetIndicator(id);
        }

        public IEnumerable<Indicator> FindIndicators(string partialname)
        {
            IIndicatorAccess access = AccessCoreFactory.GetIndicatorAccess(User);
            return access.FindIndicators(partialname);
        }
    }
}
