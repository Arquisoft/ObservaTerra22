using ObservaTerra.Core;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Backend.AccessCore
{
    class AreaAccess : IAreaAccess
    {
        public User User { get; private set; }

        public AreaAccess(DomainModel.User user)
        {
            this.User = user;
        }
        //Maria tocando cosas...
        public AreaAccess()
        {

        }

        public Area GetArea(int id)
        {
            IAreaCore core = CoreFactory.GetAreaCore();
            return core.GetArea(id);
        }

        public IEnumerable<Area> FindAreas(string partialname)
        {
            IAreaCore core = CoreFactory.GetAreaCore();
            return core.FindAreas(partialname);
        }


        public void Add(Area area)
        {
            IAreaCore core = CoreFactory.GetAreaCore();
            core.Add(area);
        }
    }
}
