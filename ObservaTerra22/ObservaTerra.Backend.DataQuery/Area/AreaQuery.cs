using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    class AreaQuery : IAreaQuery
    {
        public User User { get; private set; }

        public AreaQuery(DomainModel.User user)
        {
            this.User = user;
        }

        public Area GetArea(int id)
        {
            IAreaAccess access = AccessCoreFactory.GetAreaAccess(User);
            return access.GetArea(id);
        }

        public IEnumerable<Area> FindAreas(string partialname)
        {
            IAreaAccess access = AccessCoreFactory.GetAreaAccess(User);
            return access.FindAreas(partialname);
        }

        public void Add(Area area)
        {
            IAreaAccess access = AccessCoreFactory.GetAreaAccess(User);
            access.Add(area);
        }
    }
}
