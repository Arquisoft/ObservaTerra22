using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    class IndicatorCommand : IIndicatorCommand
    {
         public User User { get; private set; }

        public IndicatorCommand(User user)
        {
            this.User = user;
        }

        public void AddIndicator(Indicator indicator)
        {
            IIndicatorAccess access = AccessCoreFactory.GetIndicatorAccess(User);
            access.Add(indicator);
        }
    }
}
