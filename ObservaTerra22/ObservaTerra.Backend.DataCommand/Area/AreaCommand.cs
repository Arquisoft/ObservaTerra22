using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    class AreaCommand : IAreaCommand
    {
        public User User { get; private set; }

        public AreaCommand(User user)
        {
            this.User = user;
        }

        public void AddArea(Area area)
        {
            IAreaAccess access = AccessCoreFactory.GetAreaAccess(User);
            access.Add(area);
        }
    }
}
